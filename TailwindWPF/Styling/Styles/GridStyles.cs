using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace TailwindWPF.Styling.Styles
{
    public class GridStyles : BaseStyleProvider
    {
        public override Dictionary<string, Action<DependencyObject>> GetStyles() => new()
        {
            // Grid Template Columns
            ["grid-cols-1"] = d => SetGridColumns(d, 1),
            ["grid-cols-2"] = d => SetGridColumns(d, 2),
            ["grid-cols-3"] = d => SetGridColumns(d, 3),
            ["grid-cols-4"] = d => SetGridColumns(d, 4),
            ["grid-cols-5"] = d => SetGridColumns(d, 5),
            ["grid-cols-6"] = d => SetGridColumns(d, 6),
            ["grid-cols-7"] = d => SetGridColumns(d, 7),
            ["grid-cols-8"] = d => SetGridColumns(d, 8),
            ["grid-cols-9"] = d => SetGridColumns(d, 9),
            ["grid-cols-10"] = d => SetGridColumns(d, 10),
            ["grid-cols-11"] = d => SetGridColumns(d, 11),
            ["grid-cols-12"] = d => SetGridColumns(d, 12),

            // Grid Template Rows
            ["grid-rows-1"] = d => SetGridRows(d, 1),
            ["grid-rows-2"] = d => SetGridRows(d, 2),
            ["grid-rows-3"] = d => SetGridRows(d, 3),
            ["grid-rows-4"] = d => SetGridRows(d, 4),
            ["grid-rows-5"] = d => SetGridRows(d, 5),
            ["grid-rows-6"] = d => SetGridRows(d, 6),

            // Grid Column Start/End
            ["col-auto"] = d => SetGridColumn(d, GridLength.Auto),
            ["col-span-1"] = d => SetGridColumnSpan(d, 1),
            ["col-span-2"] = d => SetGridColumnSpan(d, 2),
            ["col-span-3"] = d => SetGridColumnSpan(d, 3),
            ["col-span-4"] = d => SetGridColumnSpan(d, 4),
            ["col-span-5"] = d => SetGridColumnSpan(d, 5),
            ["col-span-6"] = d => SetGridColumnSpan(d, 6),
            ["col-span-full"] = d => SetGridColumnSpan(d, int.MaxValue),

            ["col-start-1"] = d => SetGridColumnStart(d, 1),
            ["col-start-2"] = d => SetGridColumnStart(d, 2),
            ["col-start-3"] = d => SetGridColumnStart(d, 3),
            ["col-start-4"] = d => SetGridColumnStart(d, 4),
            ["col-start-5"] = d => SetGridColumnStart(d, 5),
            ["col-start-6"] = d => SetGridColumnStart(d, 6),
            ["col-start-7"] = d => SetGridColumnStart(d, 7),
            ["col-start-8"] = d => SetGridColumnStart(d, 8),
            ["col-start-9"] = d => SetGridColumnStart(d, 9),
            ["col-start-10"] = d => SetGridColumnStart(d, 10),
            ["col-start-11"] = d => SetGridColumnStart(d, 11),
            ["col-start-12"] = d => SetGridColumnStart(d, 12),

            ["col-end-1"] = d => SetGridColumnEnd(d, 1),
            ["col-end-2"] = d => SetGridColumnEnd(d, 2),
            ["col-end-3"] = d => SetGridColumnEnd(d, 3),
            ["col-end-4"] = d => SetGridColumnEnd(d, 4),
            ["col-end-5"] = d => SetGridColumnEnd(d, 5),
            ["col-end-6"] = d => SetGridColumnEnd(d, 6),
            ["col-end-7"] = d => SetGridColumnEnd(d, 7),
            ["col-end-8"] = d => SetGridColumnEnd(d, 8),
            ["col-end-9"] = d => SetGridColumnEnd(d, 9),
            ["col-end-10"] = d => SetGridColumnEnd(d, 10),
            ["col-end-11"] = d => SetGridColumnEnd(d, 11),
            ["col-end-12"] = d => SetGridColumnEnd(d, 12),
            ["col-end-13"] = d => SetGridColumnEnd(d, 13),

            // Grid Row Start/End
            ["row-auto"] = d => SetGridRow(d, GridLength.Auto),
            ["row-span-1"] = d => SetGridRowSpan(d, 1),
            ["row-span-2"] = d => SetGridRowSpan(d, 2),
            ["row-span-3"] = d => SetGridRowSpan(d, 3),
            ["row-span-4"] = d => SetGridRowSpan(d, 4),
            ["row-span-5"] = d => SetGridRowSpan(d, 5),
            ["row-span-6"] = d => SetGridRowSpan(d, 6),
            ["row-span-full"] = d => SetGridRowSpan(d, int.MaxValue),

            ["row-start-1"] = d => SetGridRowStart(d, 1),
            ["row-start-2"] = d => SetGridRowStart(d, 2),
            ["row-start-3"] = d => SetGridRowStart(d, 3),
            ["row-start-4"] = d => SetGridRowStart(d, 4),
            ["row-start-5"] = d => SetGridRowStart(d, 5),
            ["row-start-6"] = d => SetGridRowStart(d, 6),
            ["row-start-7"] = d => SetGridRowStart(d, 7),

            ["row-end-1"] = d => SetGridRowEnd(d, 1),
            ["row-end-2"] = d => SetGridRowEnd(d, 2),
            ["row-end-3"] = d => SetGridRowEnd(d, 3),
            ["row-end-4"] = d => SetGridRowEnd(d, 4),
            ["row-end-5"] = d => SetGridRowEnd(d, 5),
            ["row-end-6"] = d => SetGridRowEnd(d, 6),
            ["row-end-7"] = d => SetGridRowEnd(d, 7),

            // Gap (Grid spacing)
            ["gap-0"] = d => SetGridGap(d, 0),
            ["gap-1"] = d => SetGridGap(d, 4),
            ["gap-2"] = d => SetGridGap(d, 8),
            ["gap-3"] = d => SetGridGap(d, 12),
            ["gap-4"] = d => SetGridGap(d, 16),
            ["gap-5"] = d => SetGridGap(d, 20),
            ["gap-6"] = d => SetGridGap(d, 24),
            ["gap-8"] = d => SetGridGap(d, 32),
            ["gap-10"] = d => SetGridGap(d, 40),
            ["gap-12"] = d => SetGridGap(d, 48),

            // Column Gap
            ["gap-x-0"] = d => SetGridColumnGap(d, 0),
            ["gap-x-1"] = d => SetGridColumnGap(d, 4),
            ["gap-x-2"] = d => SetGridColumnGap(d, 8),
            ["gap-x-3"] = d => SetGridColumnGap(d, 12),
            ["gap-x-4"] = d => SetGridColumnGap(d, 16),
            ["gap-x-5"] = d => SetGridColumnGap(d, 20),
            ["gap-x-6"] = d => SetGridColumnGap(d, 24),
            ["gap-x-8"] = d => SetGridColumnGap(d, 32),

            // Row Gap
            ["gap-y-0"] = d => SetGridRowGap(d, 0),
            ["gap-y-1"] = d => SetGridRowGap(d, 4),
            ["gap-y-2"] = d => SetGridRowGap(d, 8),
            ["gap-y-3"] = d => SetGridRowGap(d, 12),
            ["gap-y-4"] = d => SetGridRowGap(d, 16),
            ["gap-y-5"] = d => SetGridRowGap(d, 20),
            ["gap-y-6"] = d => SetGridRowGap(d, 24),
            ["gap-y-8"] = d => SetGridRowGap(d, 32),
        };

        private static void SetGridColumns(DependencyObject d, int columns)
        {
            if (d is not Grid grid) return;

            grid.ColumnDefinitions.Clear();
            for (int i = 0; i < columns; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }
        }

        private static void SetGridRows(DependencyObject d, int rows)
        {
            if (d is not Grid grid) return;

            grid.RowDefinitions.Clear();
            for (int i = 0; i < rows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }
        }

        private static void SetGridColumn(DependencyObject d, GridLength width)
        {
            // TOFIX: auto case
        }

        private static void SetGridColumnSpan(DependencyObject d, int span)
        {
            if (d is not UIElement element) return;

            if (span == int.MaxValue)
            {
                // col-span-full : Total nb of col
                var parent = GetGridParent(d);
                if (parent != null)
                {
                    span = Math.Max(1, parent.ColumnDefinitions.Count);
                }
                else
                {
                    span = 12; // Default
                }
            }
            Grid.SetColumnSpan(element, span);
        }

        private static void SetGridRowSpan(DependencyObject d, int span)
        {
            if (d is not UIElement element) return;

            if (span == int.MaxValue)
            {
                // row-span-full : Total nb of line
                var parent = GetGridParent(d);
                if (parent != null)
                {
                    span = Math.Max(1, parent.RowDefinitions.Count);
                }
                else
                {
                    span = 6; // Default
                }
            }
            Grid.SetRowSpan(element, span);
        }

        private static void SetGridColumnStart(DependencyObject d, int start)
        {
            if (d is not UIElement element) return;
            Grid.SetColumn(element, start - 1); // Convert 1-based to 0-based
        }

        private static void SetGridRowStart(DependencyObject d, int start)
        {
            if (d is not UIElement element) return;
            Grid.SetRow(element, start - 1); // Convert 1-based to 0-based
        }

        private static void SetGridColumnEnd(DependencyObject d, int end)
        {
            if (d is not UIElement element) return;

            var start = Grid.GetColumn(element);
            var span = end - start - 1;
            if (span > 0)
            {
                Grid.SetColumnSpan(element, span);
            }
        }

        private static void SetGridRowEnd(DependencyObject d, int end)
        {
            if (d is not UIElement element) return;

            var start = Grid.GetRow(element);
            var span = end - start - 1;
            if (span > 0)
            {
                Grid.SetRowSpan(element, span);
            }
        }

        private static void SetGridRow(DependencyObject d, GridLength height)
        {
            // Special case
        }

        private static void SetGridGap(DependencyObject d, double gap)
        {
            SetGridColumnGap(d, gap);
            SetGridRowGap(d, gap);
        }

        private static void SetGridColumnGap(DependencyObject d, double gap)
        {
            if (d is Grid grid)
            {
                // Margin on childs for gaps
                SetGridGapProperty(grid, "ColumnGap", gap);
            }
        }

        private static void SetGridRowGap(DependencyObject d, double gap)
        {
            if (d is Grid grid)
            {
                SetGridGapProperty(grid, "RowGap", gap);
            }
        }

        private static void SetGridGapProperty(Grid grid, string property, double gap)
        {
            grid.SetValue(FrameworkElement.TagProperty, $"{property}:{gap}");

            // Margin gaps
            foreach (UIElement child in grid.Children)
            {
                if (child is FrameworkElement fe)
                {
                    var margin = fe.Margin;
                    if (property == "ColumnGap")
                    {
                        margin.Left = gap / 2;
                        margin.Right = gap / 2;
                    }
                    else if (property == "RowGap")
                    {
                        margin.Top = gap / 2;
                        margin.Bottom = gap / 2;
                    }
                    fe.Margin = margin;
                }
            }
        }

        private static Grid GetGridParent(DependencyObject d)
        {
            if (d is FrameworkElement fe)
            {
                return fe.Parent as Grid;
            }
            return null;
        }
    }
}