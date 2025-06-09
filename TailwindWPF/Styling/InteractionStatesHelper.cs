using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace TailwindWPF.Styling
{
    public static class InteractionStatesHelper
    {
        public static readonly DependencyProperty InteractiveClassProperty =
            DependencyProperty.RegisterAttached("InteractiveClass", typeof(string), typeof(InteractionStatesHelper),
                new PropertyMetadata(null, OnInteractiveClassChanged));

        public static void SetInteractiveClass(DependencyObject element, string value) =>
            element.SetValue(InteractiveClassProperty, value);

        public static string GetInteractiveClass(DependencyObject element) =>
            (string)element.GetValue(InteractiveClassProperty);

        private static void OnInteractiveClassChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not UIElement element || e.NewValue is not string classString)
                return;

            var stateClasses = ParseInteractiveClasses(classString);
            var stateManager = new ElementStateManager(element, stateClasses);

            element.SetValue(FrameworkElement.TagProperty, stateManager);
        }

        private static Dictionary<string, List<string>> ParseInteractiveClasses(string classString)
        {
            var result = new Dictionary<string, List<string>>
            {
                ["base"] = new List<string>(),
                ["hover"] = new List<string>(),
                ["focus"] = new List<string>(),
                ["active"] = new List<string>(),
                ["disabled"] = new List<string>()
            };

            var classes = classString.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var cls in classes)
            {
                if (cls.Contains(':'))
                {
                    var parts = cls.Split(':', 2);
                    var state = parts[0];
                    var className = parts[1];

                    if (result.ContainsKey(state))
                    {
                        result[state].Add(className);
                    }
                }
                else
                {
                    result["base"].Add(cls);
                }
            }

            return result;
        }
    }

    public class ElementStateManager
    {
        private readonly UIElement _element;
        private readonly Dictionary<string, List<string>> _stateClasses;
        private readonly Dictionary<string, object> _originalValues;
        private bool _isHovered;
        private bool _isFocused;
        private bool _isPressed;

        public ElementStateManager(UIElement element, Dictionary<string, List<string>> stateClasses)
        {
            _element = element;
            _stateClasses = stateClasses;
            _originalValues = new Dictionary<string, object>();

            ApplyClasses(_stateClasses["base"]);

            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _element.MouseEnter += OnMouseEnter;
            _element.MouseLeave += OnMouseLeave;
            _element.MouseLeftButtonDown += OnMouseDown;
            _element.MouseLeftButtonUp += OnMouseUp;
            _element.MouseLeave += OnMouseLeaveFromPress;

            if (_element is Control control)
            {
                control.GotFocus += OnGotFocus;
                control.LostFocus += OnLostFocus;
                control.IsEnabledChanged += OnIsEnabledChanged;
            }

            if (_element is FrameworkElement fe)
            {
                fe.GotKeyboardFocus += OnGotFocus;
                fe.LostKeyboardFocus += OnLostFocus;
            }
        }

        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            _isHovered = true;
            UpdateState();
        }

        private void OnMouseLeave(object sender, MouseEventArgs e)
        {
            _isHovered = false;
            _isPressed = false;
            UpdateState();
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            _isPressed = true;
            UpdateState();
        }

        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            _isPressed = false;
            UpdateState();
        }

        private void OnMouseLeaveFromPress(object sender, MouseEventArgs e)
        {
            _isPressed = false;
            UpdateState();
        }

        private void OnGotFocus(object sender, RoutedEventArgs e)
        {
            _isFocused = true;
            UpdateState();
        }

        private void OnLostFocus(object sender, RoutedEventArgs e)
        {
            _isFocused = false;
            UpdateState();
        }

        private void OnIsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateState();
        }

        private void UpdateState()
        {
            ApplyClasses(_stateClasses["base"]);

            // Ordered states
            bool isEnabled = true;
            if (_element is Control control)
            {
                isEnabled = control.IsEnabled;
            }

            if (!isEnabled && _stateClasses["disabled"].Count > 0)
            {
                ApplyClasses(_stateClasses["disabled"]);
            }
            else if (_isPressed && _stateClasses["active"].Count > 0)
            {
                ApplyClasses(_stateClasses["active"]);
            }
            else if (_isHovered && _stateClasses["hover"].Count > 0)
            {
                ApplyClasses(_stateClasses["hover"]);
            }

            if (_isFocused && _stateClasses["focus"].Count > 0)
            {
                ApplyClasses(_stateClasses["focus"]);
            }
        }

        private void ApplyClasses(List<string> classes)
        {
            foreach (var cls in classes)
            {
                if (TailwindMap.ClassMap.TryGetValue(cls, out var action))
                {
                    action(_element);
                }
            }
        }
    }
}