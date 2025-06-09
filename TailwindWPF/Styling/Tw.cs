using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace TailwindWPF.Styling
{
    public static class Tw
    {
        public static readonly DependencyProperty ClassProperty =
            DependencyProperty.RegisterAttached("Class", typeof(string), typeof(Tw), new PropertyMetadata(null, OnClassChanged));

        public static void SetClass(DependencyObject element, string value) =>
            element.SetValue(ClassProperty, value);

        public static string GetClass(DependencyObject element) =>
            (string)element.GetValue(ClassProperty);

        private static void OnClassChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is not string classString)
                return;

            var classes = ParseClasses(classString);

            // Bases classes
            ApplyClasses(d, classes.BaseClasses);

            if (classes.HasInteractiveClasses)
            {
                SetupInteractions(d, classes);
            }
        }

        private static ClassCollection ParseClasses(string classString)
        {
            var result = new ClassCollection();
            var classes = classString.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var cls in classes)
            {
                if (cls.Contains(':'))
                {
                    var parts = cls.Split(':', 2);
                    var state = parts[0];
                    var className = parts[1];

                    switch (state)
                    {
                        case "hover":
                            result.HoverClasses.Add(className);
                            break;
                        case "focus":
                            result.FocusClasses.Add(className);
                            break;
                        case "active":
                            result.ActiveClasses.Add(className);
                            break;
                        case "disabled":
                            result.DisabledClasses.Add(className);
                            break;
                        // Responsive
                        case "sm":
                        case "md":
                        case "lg":
                        case "xl":
                        case "2xl":
                            result.ResponsiveClasses[state].Add(className);
                            break;
                        default:
                            result.BaseClasses.Add(cls);
                            break;
                    }
                }
                else
                {
                    result.BaseClasses.Add(cls);
                }
            }

            return result;
        }

        private static void ApplyClasses(DependencyObject d, List<string> classes)
        {
            foreach (var cls in classes)
            {
                if (TailwindMap.ClassMap.TryGetValue(cls, out var action))
                {
                    action(d);
                }
            }
        }

        private static void SetupInteractions(DependencyObject d, ClassCollection classes)
        {
            if (d is not UIElement element) return;

            var stateManager = new ElementStateManager(element, classes);

            element.SetValue(FrameworkElement.TagProperty, stateManager);
        }

        private class ClassCollection
        {
            public List<string> BaseClasses { get; } = new();
            public List<string> HoverClasses { get; } = new();
            public List<string> FocusClasses { get; } = new();
            public List<string> ActiveClasses { get; } = new();
            public List<string> DisabledClasses { get; } = new();
            public Dictionary<string, List<string>> ResponsiveClasses { get; } = new()
            {
                ["sm"] = new(),
                ["md"] = new(),
                ["lg"] = new(),
                ["xl"] = new(),
                ["2xl"] = new()
            };

            public bool HasInteractiveClasses =>
                HoverClasses.Count > 0 ||
                FocusClasses.Count > 0 ||
                ActiveClasses.Count > 0 ||
                DisabledClasses.Count > 0;

            public bool HasResponsiveClasses =>
                ResponsiveClasses.Values.Any(list => list.Count > 0);
        }

        private class ElementStateManager
        {
            private readonly UIElement _element;
            private readonly ClassCollection _classes;
            private readonly Dictionary<string, object> _originalValues = new();
            private bool _isHovered;
            private bool _isFocused;
            private bool _isPressed;

            public ElementStateManager(UIElement element, ClassCollection classes)
            {
                _element = element;
                _classes = classes;

                SubscribeToEvents();

                UpdateState();
            }

            private void SubscribeToEvents()
            {
                _element.MouseEnter += OnMouseEnter;
                _element.MouseLeave += OnMouseLeave;
                _element.MouseLeftButtonDown += OnMouseDown;
                _element.MouseLeftButtonUp += OnMouseUp;

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

            private void OnMouseEnter(object sender, MouseEventArgs e) { _isHovered = true; UpdateState(); }
            private void OnMouseLeave(object sender, MouseEventArgs e) { _isHovered = false; _isPressed = false; UpdateState(); }
            private void OnMouseDown(object sender, MouseButtonEventArgs e) { _isPressed = true; UpdateState(); }
            private void OnMouseUp(object sender, MouseButtonEventArgs e) { _isPressed = false; UpdateState(); }
            private void OnGotFocus(object sender, RoutedEventArgs e) { _isFocused = true; UpdateState(); }
            private void OnLostFocus(object sender, RoutedEventArgs e) { _isFocused = false; UpdateState(); }
            private void OnIsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e) { UpdateState(); }

            private void UpdateState()
            {
                ApplyClasses(_element, _classes.BaseClasses);

                bool isEnabled = true;
                if (_element is Control control)
                {
                    isEnabled = control.IsEnabled;
                }

                // priority : disabled > active > hover > focus
                if (!isEnabled && _classes.DisabledClasses.Count > 0)
                {
                    ApplyClasses(_element, _classes.DisabledClasses);
                }
                else if (_isPressed && _classes.ActiveClasses.Count > 0)
                {
                    ApplyClasses(_element, _classes.ActiveClasses);
                }
                else if (_isHovered && _classes.HoverClasses.Count > 0)
                {
                    ApplyClasses(_element, _classes.HoverClasses);
                }

                if (_isFocused && _classes.FocusClasses.Count > 0)
                {
                    ApplyClasses(_element, _classes.FocusClasses);
                }
            }
        }
    }
}