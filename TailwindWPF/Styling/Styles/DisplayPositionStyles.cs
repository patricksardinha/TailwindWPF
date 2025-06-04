using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace TailwindWPF.Styling.Styles
{
    public class DisplayPositionStyles : BaseStyleProvider
    {
        public override Dictionary<string, Action<DependencyObject>> GetStyles() => new()
        {
            // Display
            ["block"] = d => SetDisplay(d, "block"),
            ["inline-block"] = d => SetDisplay(d, "inline-block"),
            ["inline"] = d => SetDisplay(d, "inline"),
            ["flex"] = d => SetDisplay(d, "flex"),
            ["inline-flex"] = d => SetDisplay(d, "inline-flex"),
            ["table"] = d => SetDisplay(d, "table"),
            ["inline-table"] = d => SetDisplay(d, "inline-table"),
            ["table-caption"] = d => SetDisplay(d, "table-caption"),
            ["table-cell"] = d => SetDisplay(d, "table-cell"),
            ["table-column"] = d => SetDisplay(d, "table-column"),
            ["table-column-group"] = d => SetDisplay(d, "table-column-group"),
            ["table-footer-group"] = d => SetDisplay(d, "table-footer-group"),
            ["table-header-group"] = d => SetDisplay(d, "table-header-group"),
            ["table-row-group"] = d => SetDisplay(d, "table-row-group"),
            ["table-row"] = d => SetDisplay(d, "table-row"),
            ["flow-root"] = d => SetDisplay(d, "flow-root"),
            ["grid"] = d => SetDisplay(d, "grid"),
            ["inline-grid"] = d => SetDisplay(d, "inline-grid"),
            ["contents"] = d => SetDisplay(d, "contents"),
            ["list-item"] = d => SetDisplay(d, "list-item"),
            ["hidden"] = d => SetVisibility(d, Visibility.Hidden),
            ["invisible"] = d => SetVisibility(d, Visibility.Hidden),
            ["visible"] = d => SetVisibility(d, Visibility.Visible),
            ["collapse"] = d => SetVisibility(d, Visibility.Collapsed),

            // Position
            ["static"] = d => SetPosition(d, "static"),
            ["fixed"] = d => SetPosition(d, "fixed"),
            ["absolute"] = d => SetPosition(d, "absolute"),
            ["relative"] = d => SetPosition(d, "relative"),
            ["sticky"] = d => SetPosition(d, "sticky"),

            // Top, Right, Bottom, Left
            ["inset-0"] = d => SetInset(d, 0),
            ["inset-px"] = d => SetInset(d, 1),
            ["inset-0.5"] = d => SetInset(d, 2),
            ["inset-1"] = d => SetInset(d, 4),
            ["inset-1.5"] = d => SetInset(d, 6),
            ["inset-2"] = d => SetInset(d, 8),
            ["inset-2.5"] = d => SetInset(d, 10),
            ["inset-3"] = d => SetInset(d, 12),
            ["inset-3.5"] = d => SetInset(d, 14),
            ["inset-4"] = d => SetInset(d, 16),
            ["inset-5"] = d => SetInset(d, 20),
            ["inset-6"] = d => SetInset(d, 24),
            ["inset-8"] = d => SetInset(d, 32),
            ["inset-10"] = d => SetInset(d, 40),
            ["inset-12"] = d => SetInset(d, 48),
            ["inset-16"] = d => SetInset(d, 64),
            ["inset-20"] = d => SetInset(d, 80),
            ["inset-24"] = d => SetInset(d, 96),
            ["inset-32"] = d => SetInset(d, 128),
            ["inset-40"] = d => SetInset(d, 160),
            ["inset-48"] = d => SetInset(d, 192),
            ["inset-56"] = d => SetInset(d, 224),
            ["inset-64"] = d => SetInset(d, 256),
            ["inset-auto"] = d => SetInset(d, double.NaN),
            ["inset-1/2"] = d => SetInsetPercent(d, 50),
            ["inset-1/3"] = d => SetInsetPercent(d, 33.333333),
            ["inset-2/3"] = d => SetInsetPercent(d, 66.666667),
            ["inset-1/4"] = d => SetInsetPercent(d, 25),
            ["inset-3/4"] = d => SetInsetPercent(d, 75),
            ["inset-full"] = d => SetInsetPercent(d, 100),

            // Inset X
            ["inset-x-0"] = d => SetInsetX(d, 0),
            ["inset-x-1"] = d => SetInsetX(d, 4),
            ["inset-x-2"] = d => SetInsetX(d, 8),
            ["inset-x-4"] = d => SetInsetX(d, 16),
            ["inset-x-8"] = d => SetInsetX(d, 32),
            ["inset-x-auto"] = d => SetInsetX(d, double.NaN),

            // Inset Y
            ["inset-y-0"] = d => SetInsetY(d, 0),
            ["inset-y-1"] = d => SetInsetY(d, 4),
            ["inset-y-2"] = d => SetInsetY(d, 8),
            ["inset-y-4"] = d => SetInsetY(d, 16),
            ["inset-y-8"] = d => SetInsetY(d, 32),
            ["inset-y-auto"] = d => SetInsetY(d, double.NaN),

            // Top
            ["top-0"] = d => SetTop(d, 0),
            ["top-px"] = d => SetTop(d, 1),
            ["top-0.5"] = d => SetTop(d, 2),
            ["top-1"] = d => SetTop(d, 4),
            ["top-1.5"] = d => SetTop(d, 6),
            ["top-2"] = d => SetTop(d, 8),
            ["top-2.5"] = d => SetTop(d, 10),
            ["top-3"] = d => SetTop(d, 12),
            ["top-3.5"] = d => SetTop(d, 14),
            ["top-4"] = d => SetTop(d, 16),
            ["top-5"] = d => SetTop(d, 20),
            ["top-6"] = d => SetTop(d, 24),
            ["top-8"] = d => SetTop(d, 32),
            ["top-10"] = d => SetTop(d, 40),
            ["top-12"] = d => SetTop(d, 48),
            ["top-16"] = d => SetTop(d, 64),
            ["top-20"] = d => SetTop(d, 80),
            ["top-24"] = d => SetTop(d, 96),
            ["top-32"] = d => SetTop(d, 128),
            ["top-40"] = d => SetTop(d, 160),
            ["top-48"] = d => SetTop(d, 192),
            ["top-56"] = d => SetTop(d, 224),
            ["top-64"] = d => SetTop(d, 256),
            ["top-auto"] = d => SetTop(d, double.NaN),
            ["top-1/2"] = d => SetTopPercent(d, 50),
            ["top-1/3"] = d => SetTopPercent(d, 33.333333),
            ["top-2/3"] = d => SetTopPercent(d, 66.666667),
            ["top-1/4"] = d => SetTopPercent(d, 25),
            ["top-3/4"] = d => SetTopPercent(d, 75),
            ["top-full"] = d => SetTopPercent(d, 100),

            // Right
            ["right-0"] = d => SetRight(d, 0),
            ["right-1"] = d => SetRight(d, 4),
            ["right-2"] = d => SetRight(d, 8),
            ["right-4"] = d => SetRight(d, 16),
            ["right-8"] = d => SetRight(d, 32),
            ["right-auto"] = d => SetRight(d, double.NaN),

            // Bottom
            ["bottom-0"] = d => SetBottom(d, 0),
            ["bottom-1"] = d => SetBottom(d, 4),
            ["bottom-2"] = d => SetBottom(d, 8),
            ["bottom-4"] = d => SetBottom(d, 16),
            ["bottom-8"] = d => SetBottom(d, 32),
            ["bottom-auto"] = d => SetBottom(d, double.NaN),

            // Left
            ["left-0"] = d => SetLeft(d, 0),
            ["left-1"] = d => SetLeft(d, 4),
            ["left-2"] = d => SetLeft(d, 8),
            ["left-4"] = d => SetLeft(d, 16),
            ["left-8"] = d => SetLeft(d, 32),
            ["left-auto"] = d => SetLeft(d, double.NaN),

            // Z-Index
            ["z-0"] = d => SetZIndex(d, 0),
            ["z-10"] = d => SetZIndex(d, 10),
            ["z-20"] = d => SetZIndex(d, 20),
            ["z-30"] = d => SetZIndex(d, 30),
            ["z-40"] = d => SetZIndex(d, 40),
            ["z-50"] = d => SetZIndex(d, 50),
            ["z-auto"] = d => SetZIndex(d, 0),
        };

        private static void SetDisplay(DependencyObject d, string display)
        {
            if (d is FrameworkElement fe)
            {
                fe.SetValue(FrameworkElement.TagProperty, $"display:{display}");

                switch (display)
                {
                    case "block":
                        fe.HorizontalAlignment = HorizontalAlignment.Stretch;
                        break;
                    case "inline":
                    case "inline-block":
                        fe.HorizontalAlignment = HorizontalAlignment.Left;
                        break;
                    case "flex":
                    case "inline-flex":
                        // FlexboxStyles
                        break;
                    case "grid":
                    case "inline-grid":
                        // GridStyles
                        break;
                }
            }
        }

        private static void SetVisibility(DependencyObject d, Visibility visibility)
        {
            if (d is UIElement element)
            {
                element.Visibility = visibility;
            }
        }

        private static void SetPosition(DependencyObject d, string position)
        {
            if (d is FrameworkElement fe)
            {
                fe.SetValue(FrameworkElement.TagProperty, $"position:{position}");

                switch (position)
                {
                    case "absolute":
                    case "fixed":
                        // Canvas for absolute
                        if (fe.Parent is Canvas)
                        {
                            // Tofix: check parent position?
                        }
                        else
                        {
                            fe.SetValue(FrameworkElement.TagProperty, $"position:{position}");
                        }
                        break;
                    case "relative":
                        // Default
                        break;
                    case "sticky":
                        fe.SetValue(FrameworkElement.TagProperty, "position:sticky");
                        break;
                }
            }
        }

        private static void SetInset(DependencyObject d, double value)
        {
            SetTop(d, value);
            SetRight(d, value);
            SetBottom(d, value);
            SetLeft(d, value);
        }

        private static void SetInsetPercent(DependencyObject d, double percent)
        {
            if (d is FrameworkElement fe)
            {
                fe.SetValue(FrameworkElement.TagProperty, $"inset:{percent}%");
            }
        }

        private static void SetInsetX(DependencyObject d, double value)
        {
            SetLeft(d, value);
            SetRight(d, value);
        }

        private static void SetInsetY(DependencyObject d, double value)
        {
            SetTop(d, value);
            SetBottom(d, value);
        }

        private static void SetTop(DependencyObject d, double value)
        {
            if (d is FrameworkElement fe)
            {
                if (fe.Parent is Canvas)
                {
                    Canvas.SetTop(fe, value);
                }
                else
                {
                    var margin = fe.Margin;
                    fe.Margin = new Thickness(margin.Left, value, margin.Right, margin.Bottom);
                }
            }
        }

        private static void SetTopPercent(DependencyObject d, double percent)
        {
            if (d is FrameworkElement fe)
            {
                fe.SetValue(FrameworkElement.TagProperty, $"top:{percent}%");
            }
        }

        private static void SetRight(DependencyObject d, double value)
        {
            if (d is FrameworkElement fe)
            {
                if (fe.Parent is Canvas)
                {
                    Canvas.SetRight(fe, value);
                }
                else
                {
                    var margin = fe.Margin;
                    fe.Margin = new Thickness(margin.Left, margin.Top, value, margin.Bottom);
                }
            }
        }

        private static void SetBottom(DependencyObject d, double value)
        {
            if (d is FrameworkElement fe)
            {
                if (fe.Parent is Canvas)
                {
                    Canvas.SetBottom(fe, value);
                }
                else
                {
                    var margin = fe.Margin;
                    fe.Margin = new Thickness(margin.Left, margin.Top, margin.Right, value);
                }
            }
        }

        private static void SetLeft(DependencyObject d, double value)
        {
            if (d is FrameworkElement fe)
            {
                if (fe.Parent is Canvas)
                {
                    Canvas.SetLeft(fe, value);
                }
                else
                {
                    var margin = fe.Margin;
                    fe.Margin = new Thickness(value, margin.Top, margin.Right, margin.Bottom);
                }
            }
        }

        private static void SetZIndex(DependencyObject d, int value)
        {
            if (d is UIElement element)
            {
                Panel.SetZIndex(element, value);
            }
        }
    }
}