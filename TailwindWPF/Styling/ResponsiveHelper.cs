using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace TailwindWPF.Styling
{
    public static class ResponsiveHelper
    {
        public static readonly DependencyProperty ResponsiveClassProperty =
            DependencyProperty.RegisterAttached("ResponsiveClass", typeof(string), typeof(ResponsiveHelper),
                new PropertyMetadata(null, OnResponsiveClassChanged));

        // Breakpoints standards
        public static readonly Dictionary<string, double> Breakpoints = new()
        {
            ["sm"] = 640,   // Small devices
            ["md"] = 768,   // Medium devices  
            ["lg"] = 1024,  // Large devices
            ["xl"] = 1280,  // Extra large devices
            ["2xl"] = 1536  // 2X Extra large devices
        };

        public static void SetResponsiveClass(DependencyObject element, string value) =>
            element.SetValue(ResponsiveClassProperty, value);

        public static string GetResponsiveClass(DependencyObject element) =>
            (string)element.GetValue(ResponsiveClassProperty);

        private static void OnResponsiveClassChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not FrameworkElement element || e.NewValue is not string classString)
                return;

            // Sub event size changed
            element.SizeChanged += (s, args) => ApplyResponsiveClasses(element, classString);
            element.Loaded += (s, args) => ApplyResponsiveClasses(element, classString);

            if (element.ActualWidth > 0)
            {
                ApplyResponsiveClasses(element, classString);
            }
        }

        private static void ApplyResponsiveClasses(FrameworkElement element, string classString)
        {
            var parentWindow = Window.GetWindow(element);
            if (parentWindow == null) return;

            var windowWidth = parentWindow.ActualWidth;
            var classes = ParseResponsiveClasses(classString);

            string currentBreakpoint = GetCurrentBreakpoint(windowWidth);

            foreach (var (breakpoint, classList) in classes)
            {
                bool shouldApply = ShouldApplyBreakpoint(breakpoint, currentBreakpoint, windowWidth);

                if (shouldApply)
                {
                    foreach (var cls in classList)
                    {
                        if (TailwindMap.ClassMap.TryGetValue(cls, out var action))
                        {
                            action(element);
                        }
                    }
                }
            }
        }

        private static Dictionary<string, List<string>> ParseResponsiveClasses(string classString)
        {
            var result = new Dictionary<string, List<string>>
            {
                ["base"] = new List<string>() // Default = no breakpoints
            };

            var classes = classString.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var cls in classes)
            {
                if (cls.Contains(':'))
                {
                    var parts = cls.Split(':', 2);
                    var breakpoint = parts[0];
                    var className = parts[1];

                    if (!result.ContainsKey(breakpoint))
                        result[breakpoint] = new List<string>();

                    result[breakpoint].Add(className);
                }
                else
                {
                    result["base"].Add(cls);
                }
            }

            return result;
        }

        private static string GetCurrentBreakpoint(double width)
        {
            if (width >= Breakpoints["2xl"]) return "2xl";
            if (width >= Breakpoints["xl"]) return "xl";
            if (width >= Breakpoints["lg"]) return "lg";
            if (width >= Breakpoints["md"]) return "md";
            if (width >= Breakpoints["sm"]) return "sm";
            return "base";
        }

        private static bool ShouldApplyBreakpoint(string breakpoint, string currentBreakpoint, double width)
        {
            if (breakpoint == "base") return true;

            if (Breakpoints.TryGetValue(breakpoint, out var minWidth))
            {
                return width >= minWidth;
            }

            return false;
        }
    }

    // Extension of Tw for breakpoints
    // ResponsiveTw calls the ResponsiveHelper which listen changed size event meaning that performances will be impacted
    // Tofix: low impact for huge amount elements using ResponsiveTw
    public static class ResponsiveTw
    {
        public static readonly DependencyProperty ResponsiveClassProperty =
            DependencyProperty.RegisterAttached("ResponsiveClass", typeof(string), typeof(ResponsiveTw),
                new PropertyMetadata(null, OnResponsiveClassChanged));

        public static void SetResponsiveClass(DependencyObject element, string value) =>
            element.SetValue(ResponsiveClassProperty, value);

        public static string GetResponsiveClass(DependencyObject element) =>
            (string)element.GetValue(ResponsiveClassProperty);

        private static void OnResponsiveClassChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not FrameworkElement element || e.NewValue is not string classString)
                return;

            ResponsiveHelper.SetResponsiveClass(element, classString);
        }
    }
}