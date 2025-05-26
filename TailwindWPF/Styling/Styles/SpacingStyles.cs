using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace TailwindWPF.Styling.Styles
{
    public class SpacingStyles : BaseStyleProvider
    {
        private static readonly Dictionary<string, double> Spacing = new()
        {
            ["0"] = 0,
            ["px"] = 1,
            ["0.5"] = 2,
            ["1"] = 4,
            ["1.5"] = 6,
            ["2"] = 8,
            ["2.5"] = 10,
            ["3"] = 12,
            ["3.5"] = 14,
            ["4"] = 16,
            ["5"] = 20,
            ["6"] = 24,
            ["7"] = 28,
            ["8"] = 32,
            ["9"] = 36,
            ["10"] = 40,
            ["11"] = 44,
            ["12"] = 48,
        };

        public override Dictionary<string, Action<DependencyObject>> GetStyles()
        {
            var styles = new Dictionary<string, Action<DependencyObject>>();

            foreach (var (key, value) in Spacing)
            {
                // Padding
                styles[$"p-{key}"] = d => SetPadding(d, new Thickness(value));
                styles[$"px-{key}"] = d => UpdatePadding(d, (old) => new Thickness(value, old.Top, value, old.Bottom));
                styles[$"py-{key}"] = d => UpdatePadding(d, (old) => new Thickness(old.Left, value, old.Right, value));
                styles[$"pt-{key}"] = d => UpdatePadding(d, (old) => new Thickness(old.Left, value, old.Right, old.Bottom));
                styles[$"pr-{key}"] = d => UpdatePadding(d, (old) => new Thickness(old.Left, old.Top, value, old.Bottom));
                styles[$"pb-{key}"] = d => UpdatePadding(d, (old) => new Thickness(old.Left, old.Top, old.Right, value));
                styles[$"pl-{key}"] = d => UpdatePadding(d, (old) => new Thickness(value, old.Top, old.Right, old.Bottom));

                // Margin
                styles[$"m-{key}"] = d => SetMargin(d, new Thickness(value));
                styles[$"mx-{key}"] = d => UpdateMargin(d, (old) => new Thickness(value, old.Top, value, old.Bottom));
                styles[$"my-{key}"] = d => UpdateMargin(d, (old) => new Thickness(old.Left, value, old.Right, value));
                styles[$"mt-{key}"] = d => UpdateMargin(d, (old) => new Thickness(old.Left, value, old.Right, old.Bottom));
                styles[$"mr-{key}"] = d => UpdateMargin(d, (old) => new Thickness(old.Left, old.Top, value, old.Bottom));
                styles[$"mb-{key}"] = d => UpdateMargin(d, (old) => new Thickness(old.Left, old.Top, old.Right, value));
                styles[$"ml-{key}"] = d => UpdateMargin(d, (old) => new Thickness(value, old.Top, old.Right, old.Bottom));
            }

            // Margin auto
            styles["m-auto"] = d => SetHorizontalCenter(d);
            styles["mx-auto"] = d => SetHorizontalCenter(d);
            styles["my-auto"] = d => SetVerticalCenter(d);

            return styles;
        }

        private void SetPadding(DependencyObject obj, Thickness value)
        {
            if (obj is Control control)
                control.Padding = value;
        }

        private void UpdatePadding(DependencyObject obj, Func<Thickness, Thickness> update)
        {
            if (obj is Control control)
                control.Padding = update(control.Padding);
        }

        private void SetMargin(DependencyObject obj, Thickness value)
        {
            if (obj is FrameworkElement fe)
                fe.Margin = value;
        }

        private void UpdateMargin(DependencyObject obj, Func<Thickness, Thickness> update)
        {
            if (obj is FrameworkElement fe)
                fe.Margin = update(fe.Margin);
        }

        private void SetHorizontalCenter(DependencyObject obj)
        {
            if (obj is FrameworkElement fe)
                fe.HorizontalAlignment = HorizontalAlignment.Center;
        }

        private void SetVerticalCenter(DependencyObject obj)
        {
            if (obj is FrameworkElement fe)
                fe.VerticalAlignment = VerticalAlignment.Center;
        }
    }
}
