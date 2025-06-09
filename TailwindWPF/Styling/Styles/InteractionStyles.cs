using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace TailwindWPF.Styling.Styles
{
    public class InteractionStyles : BaseStyleProvider
    {
        public override Dictionary<string, Action<DependencyObject>> GetStyles() => new()
        {
            // Focus Ring
            ["focus:ring-0"] = d => { },
            ["focus:ring-1"] = d => SetFocusRing(d, 1, Colors.Blue),
            ["focus:ring-2"] = d => SetFocusRing(d, 2, Colors.Blue),
            ["focus:ring-4"] = d => SetFocusRing(d, 4, Colors.Blue),
            ["focus:ring-8"] = d => SetFocusRing(d, 8, Colors.Blue),

            // Focus Ring Colors
            ["focus:ring-blue-300"] = d => SetFocusRing(d, 3, (Color)ColorConverter.ConvertFromString("#93C5FD")),
            ["focus:ring-blue-500"] = d => SetFocusRing(d, 3, (Color)ColorConverter.ConvertFromString("#3B82F6")),
            ["focus:ring-green-300"] = d => SetFocusRing(d, 3, (Color)ColorConverter.ConvertFromString("#86EFAC")),
            ["focus:ring-red-300"] = d => SetFocusRing(d, 3, (Color)ColorConverter.ConvertFromString("#FCA5A5")),
            ["focus:ring-yellow-300"] = d => SetFocusRing(d, 3, (Color)ColorConverter.ConvertFromString("#FCD34D")),
            ["focus:ring-purple-300"] = d => SetFocusRing(d, 3, (Color)ColorConverter.ConvertFromString("#D8B4FE")),

            // Outline 
            ["focus:outline-none"] = d => RemoveOutline(d),
            ["focus:outline-1"] = d => SetOutline(d, 1, Colors.Blue),
            ["focus:outline-2"] = d => SetOutline(d, 2, Colors.Blue),
            ["focus:outline-blue-500"] = d => SetOutline(d, 2, (Color)ColorConverter.ConvertFromString("#3B82F6")),

            // Hover Transforms
            ["hover:scale-105"] = d => SetHoverScale(d, 1.05),
            ["hover:scale-110"] = d => SetHoverScale(d, 1.1),
            ["hover:-translate-y-1"] = d => SetHoverTranslateY(d, -4),
            ["hover:-translate-y-2"] = d => SetHoverTranslateY(d, -8),

            // Active Transforms
            ["active:scale-95"] = d => SetActiveScale(d, 0.95),
            ["active:scale-90"] = d => SetActiveScale(d, 0.9),
            ["active:translate-y-1"] = d => SetActiveTranslateY(d, 4),

            // Disabled States
            ["disabled:opacity-50"] = d => SetProperty(d, UIElement.OpacityProperty, 0.5),
            ["disabled:opacity-25"] = d => SetProperty(d, UIElement.OpacityProperty, 0.25),
            ["disabled:cursor-not-allowed"] = d => SetProperty(d, FrameworkElement.CursorProperty, Cursors.No),

            // Cursor
            ["cursor-auto"] = d => SetCursor(d, Cursors.Arrow),
            ["cursor-default"] = d => SetCursor(d, Cursors.Arrow),
            ["cursor-pointer"] = d => SetCursor(d, Cursors.Hand),
            ["cursor-wait"] = d => SetCursor(d, Cursors.Wait),
            ["cursor-text"] = d => SetCursor(d, Cursors.IBeam),
            ["cursor-move"] = d => SetCursor(d, Cursors.SizeAll),
            ["cursor-not-allowed"] = d => SetCursor(d, Cursors.No),

            // Transition Classes 
            ["transition-none"] = d => SetTransitionInfo(d, "none"),
            ["transition-all"] = d => SetTransitionInfo(d, "all"),
            ["transition"] = d => SetTransitionInfo(d, "default"),
            ["transition-colors"] = d => SetTransitionInfo(d, "colors"),
            ["transition-opacity"] = d => SetTransitionInfo(d, "opacity"),
            ["transition-shadow"] = d => SetTransitionInfo(d, "shadow"),
            ["transition-transform"] = d => SetTransitionInfo(d, "transform"),

            // Duration
            ["duration-75"] = d => SetDurationInfo(d, 75),
            ["duration-100"] = d => SetDurationInfo(d, 100),
            ["duration-150"] = d => SetDurationInfo(d, 150),
            ["duration-200"] = d => SetDurationInfo(d, 200),
            ["duration-300"] = d => SetDurationInfo(d, 300),
            ["duration-500"] = d => SetDurationInfo(d, 500),
            ["duration-700"] = d => SetDurationInfo(d, 700),
            ["duration-1000"] = d => SetDurationInfo(d, 1000),
        };

        private static void SetFocusRing(DependencyObject d, double width, Color color)
        {
            if (d is UIElement element)
            {
                var glowEffect = new DropShadowEffect
                {
                    Color = color,
                    Direction = 0,
                    ShadowDepth = 0,
                    BlurRadius = width * 2,
                    Opacity = 0.5
                };
                element.Effect = glowEffect;
            }
        }

        private static void RemoveOutline(DependencyObject d)
        {
            if (d is Control control)
            {
                control.BorderBrush = Brushes.Transparent;
                control.BorderThickness = new Thickness(0);
            }
        }

        private static void SetOutline(DependencyObject d, double width, Color color)
        {
            if (d is Control control)
            {
                control.BorderBrush = new SolidColorBrush(color);
                control.BorderThickness = new Thickness(width);
            }
        }

        private static void SetHoverScale(DependencyObject d, double scale)
        {
            if (d is UIElement element)
            {
                element.RenderTransform = new ScaleTransform(scale, scale);
            }
        }

        private static void SetHoverTranslateY(DependencyObject d, double translateY)
        {
            if (d is UIElement element)
            {
                element.RenderTransform = new TranslateTransform(0, translateY);
            }
        }

        private static void SetActiveScale(DependencyObject d, double scale)
        {
            if (d is UIElement element)
            {
                element.RenderTransform = new ScaleTransform(scale, scale);
            }
        }

        private static void SetActiveTranslateY(DependencyObject d, double translateY)
        {
            if (d is UIElement element)
            {
                element.RenderTransform = new TranslateTransform(0, translateY);
            }
        }

        private static void SetProperty(DependencyObject d, DependencyProperty property, object value)
        {
            d.SetValue(property, value);
        }

        private static void SetCursor(DependencyObject d, Cursor cursor)
        {
            if (d is FrameworkElement element)
            {
                element.Cursor = cursor;
            }
        }

        private static void SetTransitionInfo(DependencyObject d, string transitionType)
        {
            if (d is FrameworkElement element)
            {
                var currentTag = element.Tag?.ToString() ?? "";
                element.Tag = $"{currentTag};transition:{transitionType}";
            }
        }

        private static void SetDurationInfo(DependencyObject d, int milliseconds)
        {
            if (d is FrameworkElement element)
            {
                var currentTag = element.Tag?.ToString() ?? "";
                element.Tag = $"{currentTag};duration:{milliseconds}";
            }
        }
    }
}