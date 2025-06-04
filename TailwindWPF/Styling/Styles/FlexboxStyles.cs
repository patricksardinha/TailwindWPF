using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace TailwindWPF.Styling.Styles
{
    public class FlexboxStyles : BaseStyleProvider
    {
        public override Dictionary<string, Action<DependencyObject>> GetStyles() => new()
        {
            // Display Flex
            ["flex"] = d => SetFlexContainer(d),
            ["inline-flex"] = d => SetInlineFlexContainer(d),

            // Flex Direction
            ["flex-row"] = d => SetFlexDirection(d, Orientation.Horizontal),
            ["flex-row-reverse"] = d => SetFlexDirection(d, Orientation.Horizontal, reverse: true),
            ["flex-col"] = d => SetFlexDirection(d, Orientation.Vertical),
            ["flex-col-reverse"] = d => SetFlexDirection(d, Orientation.Vertical, reverse: true),

            // Flex Wrap
            ["flex-wrap"] = d => SetFlexWrap(d, true),
            ["flex-nowrap"] = d => SetFlexWrap(d, false),

            // Justify Content
            ["justify-start"] = d => SetJustifyContent(d, HorizontalAlignment.Left),
            ["justify-end"] = d => SetJustifyContent(d, HorizontalAlignment.Right),
            ["justify-center"] = d => SetJustifyContent(d, HorizontalAlignment.Center),
            ["justify-between"] = d => SetJustifyContent(d, HorizontalAlignment.Stretch), // Approx.
            ["justify-around"] = d => SetJustifyContent(d, HorizontalAlignment.Center), // Approx.
            ["justify-evenly"] = d => SetJustifyContent(d, HorizontalAlignment.Center), // Approx.

            // Align Items
            ["items-start"] = d => SetAlignItems(d, VerticalAlignment.Top),
            ["items-end"] = d => SetAlignItems(d, VerticalAlignment.Bottom),
            ["items-center"] = d => SetAlignItems(d, VerticalAlignment.Center),
            ["items-baseline"] = d => SetAlignItems(d, VerticalAlignment.Bottom), // Approx.
            ["items-stretch"] = d => SetAlignItems(d, VerticalAlignment.Stretch),

            // Align Content
            ["content-start"] = d => SetAlignContent(d, VerticalAlignment.Top),
            ["content-end"] = d => SetAlignContent(d, VerticalAlignment.Bottom),
            ["content-center"] = d => SetAlignContent(d, VerticalAlignment.Center),
            ["content-between"] = d => SetAlignContent(d, VerticalAlignment.Stretch),
            ["content-around"] = d => SetAlignContent(d, VerticalAlignment.Center),
            ["content-evenly"] = d => SetAlignContent(d, VerticalAlignment.Center),

            // Align Self
            ["self-auto"] = d => SetAlignSelf(d, VerticalAlignment.Stretch),
            ["self-start"] = d => SetAlignSelf(d, VerticalAlignment.Top),
            ["self-end"] = d => SetAlignSelf(d, VerticalAlignment.Bottom),
            ["self-center"] = d => SetAlignSelf(d, VerticalAlignment.Center),
            ["self-stretch"] = d => SetAlignSelf(d, VerticalAlignment.Stretch),

            // Flex Grow
            ["flex-1"] = d => SetFlexGrow(d, 1),
            ["flex-auto"] = d => SetFlexAuto(d),
            ["flex-initial"] = d => SetFlexInitial(d),
            ["flex-none"] = d => SetFlexNone(d),

            // Flex Grow individual
            ["grow"] = d => SetFlexGrow(d, 1),
            ["grow-0"] = d => SetFlexGrow(d, 0),

            // Flex Shrink
            ["shrink"] = d => SetFlexShrink(d, 1),
            ["shrink-0"] = d => SetFlexShrink(d, 0),

            // Order
            ["order-1"] = d => SetFlexOrder(d, 1),
            ["order-2"] = d => SetFlexOrder(d, 2),
            ["order-3"] = d => SetFlexOrder(d, 3),
            ["order-4"] = d => SetFlexOrder(d, 4),
            ["order-5"] = d => SetFlexOrder(d, 5),
            ["order-6"] = d => SetFlexOrder(d, 6),
            ["order-7"] = d => SetFlexOrder(d, 7),
            ["order-8"] = d => SetFlexOrder(d, 8),
            ["order-9"] = d => SetFlexOrder(d, 9),
            ["order-10"] = d => SetFlexOrder(d, 10),
            ["order-11"] = d => SetFlexOrder(d, 11),
            ["order-12"] = d => SetFlexOrder(d, 12),
            ["order-first"] = d => SetFlexOrder(d, -1),
            ["order-last"] = d => SetFlexOrder(d, 999),
            ["order-none"] = d => SetFlexOrder(d, 0),
        };

        private static void SetFlexContainer(DependencyObject d)
        {
            if (d is Panel panel)
            {
                panel.SetValue(FrameworkElement.TagProperty, "flex-container");

                if (panel is StackPanel stackPanel)
                {
                    stackPanel.Orientation = Orientation.Horizontal;
                }
            }
        }

        private static void SetInlineFlexContainer(DependencyObject d)
        {
            SetFlexContainer(d);
        }

        private static void SetFlexDirection(DependencyObject d, Orientation orientation, bool reverse = false)
        {
            if (d is StackPanel stackPanel)
            {
                stackPanel.Orientation = orientation;
                if (reverse)
                {
                    stackPanel.FlowDirection = orientation == Orientation.Horizontal
                        ? FlowDirection.RightToLeft
                        : FlowDirection.LeftToRight;
                }
            }
            else if (d is DockPanel dockPanel && reverse)
            {
                dockPanel.FlowDirection = FlowDirection.RightToLeft;
            }
        }

        private static void SetFlexWrap(DependencyObject d, bool wrap)
        {
            if (d is Panel panel)
            {
                panel.SetValue(FrameworkElement.TagProperty, wrap ? "flex-wrap" : "flex-nowrap");
            }
        }

        private static void SetJustifyContent(DependencyObject d, HorizontalAlignment alignment)
        {
            if (d is StackPanel stackPanel && stackPanel.Orientation == Orientation.Horizontal)
            {
                stackPanel.HorizontalAlignment = alignment;
            }
            else if (d is Panel panel)
            {
                panel.HorizontalAlignment = alignment;
            }
        }

        private static void SetAlignItems(DependencyObject d, VerticalAlignment alignment)
        {
            if (d is StackPanel stackPanel && stackPanel.Orientation == Orientation.Vertical)
            {
                stackPanel.VerticalAlignment = alignment;
            }
            else if (d is Panel panel)
            {
                panel.VerticalAlignment = alignment;

                foreach (UIElement child in panel.Children)
                {
                    if (child is FrameworkElement fe)
                    {
                        fe.VerticalAlignment = alignment;
                    }
                }
            }
        }

        private static void SetAlignContent(DependencyObject d, VerticalAlignment alignment)
        {
            if (d is Panel panel)
            {
                panel.VerticalAlignment = alignment;
            }
        }

        private static void SetAlignSelf(DependencyObject d, VerticalAlignment alignment)
        {
            if (d is FrameworkElement fe)
            {
                fe.VerticalAlignment = alignment;
            }
        }

        private static void SetFlexGrow(DependencyObject d, double grow)
        {
            if (d is FrameworkElement fe)
            {
                if (grow > 0)
                {
                    fe.HorizontalAlignment = HorizontalAlignment.Stretch;
                    fe.SetValue(Grid.ColumnProperty, 0);
                    fe.SetValue(Grid.ColumnSpanProperty, 1);
                }
                fe.SetValue(FrameworkElement.TagProperty, $"flex-grow:{grow}");
            }
        }

        private static void SetFlexShrink(DependencyObject d, double shrink)
        {
            if (d is FrameworkElement fe)
            {
                fe.SetValue(FrameworkElement.TagProperty, $"flex-shrink:{shrink}");
            }
        }

        private static void SetFlexAuto(DependencyObject d)
        {
            if (d is FrameworkElement fe)
            {
                fe.HorizontalAlignment = HorizontalAlignment.Stretch;
                fe.VerticalAlignment = VerticalAlignment.Stretch;
            }
        }

        private static void SetFlexInitial(DependencyObject d)
        {
            if (d is FrameworkElement fe)
            {
                fe.HorizontalAlignment = HorizontalAlignment.Left;
                fe.VerticalAlignment = VerticalAlignment.Top;
            }
        }

        private static void SetFlexNone(DependencyObject d)
        {
            if (d is FrameworkElement fe)
            {
                fe.HorizontalAlignment = HorizontalAlignment.Left;
                fe.VerticalAlignment = VerticalAlignment.Top;
            }
        }

        private static void SetFlexOrder(DependencyObject d, int order)
        {
            if (d is FrameworkElement fe)
            {
                fe.SetValue(Panel.ZIndexProperty, order);
                fe.SetValue(FrameworkElement.TagProperty, $"flex-order:{order}");
            }
        }
    }
}