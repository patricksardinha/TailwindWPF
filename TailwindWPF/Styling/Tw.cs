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

            if (classes.HasResponsiveClasses)
            {
                SetupResponsive(d, classes);
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
                            if (IsResponsiveInteractive(cls))
                            {
                                ParseResponsiveInteractive(cls, result);
                            }
                            else
                            {
                                result.BaseClasses.Add(cls); // Si on ne reconnaît pas, on ajoute tel quel
                            }
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

        private static bool IsResponsiveInteractive(string cls)
        {
            var parts = cls.Split(':');
            return parts.Length >= 3 &&
                   (parts[0] == "sm" || parts[0] == "md" || parts[0] == "lg" || parts[0] == "xl" || parts[0] == "2xl") &&
                   (parts[1] == "hover" || parts[1] == "focus" || parts[1] == "active" || parts[1] == "disabled");
        }

        private static void ParseResponsiveInteractive(string cls, ClassCollection result)
        {
            var parts = cls.Split(':', 3);
            if (parts.Length == 3)
            {
                var breakpoint = parts[0];
                var state = parts[1];
                var className = parts[2];

                if (!result.ResponsiveInteractiveClasses.ContainsKey(breakpoint))
                {
                    result.ResponsiveInteractiveClasses[breakpoint] = new Dictionary<string, List<string>>
                    {
                        ["hover"] = new(),
                        ["focus"] = new(),
                        ["active"] = new(),
                        ["disabled"] = new()
                    };
                }

                if (result.ResponsiveInteractiveClasses[breakpoint].ContainsKey(state))
                {
                    result.ResponsiveInteractiveClasses[breakpoint][state].Add(className);
                }
            }
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

            var currentTag = element.GetValue(FrameworkElement.TagProperty);
            element.SetValue(FrameworkElement.TagProperty, new { StateManager = stateManager, OriginalTag = currentTag });
        }

        private static void SetupResponsive(DependencyObject d, ClassCollection classes)
        {
            if (d is not FrameworkElement element) return;

            element.SizeChanged += (s, args) => ApplyResponsiveClasses(element, classes);
            element.Loaded += (s, args) => ApplyResponsiveClasses(element, classes);

            if (element.ActualWidth > 0)
            {
                ApplyResponsiveClasses(element, classes);
            }
        }

        private static void ApplyResponsiveClasses(FrameworkElement element, ClassCollection classes)
        {
            var parentWindow = Window.GetWindow(element);
            if (parentWindow == null) return;

            var windowWidth = parentWindow.ActualWidth;
            var currentBreakpoint = GetCurrentBreakpoint(windowWidth);

            foreach (var (breakpoint, classList) in classes.ResponsiveClasses)
            {
                bool shouldApply = ShouldApplyBreakpoint(breakpoint, windowWidth);

                if (shouldApply)
                {
                    ApplyClasses(element, classList);
                }
            }
        }

        private static string GetCurrentBreakpoint(double width)
        {
            if (width >= 1536) return "2xl";
            if (width >= 1280) return "xl";
            if (width >= 1024) return "lg";
            if (width >= 768) return "md";
            if (width >= 640) return "sm";
            return "base";
        }

        private static bool ShouldApplyBreakpoint(string breakpoint, double width)
        {
            var breakpoints = new Dictionary<string, double>
            {
                ["sm"] = 640,
                ["md"] = 768,
                ["lg"] = 1024,
                ["xl"] = 1280,
                ["2xl"] = 1536
            };

            if (breakpoints.TryGetValue(breakpoint, out var minWidth))
            {
                return width >= minWidth;
            }
            return false;
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

            public Dictionary<string, Dictionary<string, List<string>>> ResponsiveInteractiveClasses { get; } = new();

            public bool HasInteractiveClasses =>
                HoverClasses.Count > 0 ||
                FocusClasses.Count > 0 ||
                ActiveClasses.Count > 0 ||
                DisabledClasses.Count > 0;

            public bool HasResponsiveClasses =>
                 ResponsiveClasses.Values.Any(list => list.Count > 0) ||
                 ResponsiveInteractiveClasses.Count > 0;
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