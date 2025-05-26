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
        public override Dictionary<string, Action<Control>> GetStyles() => new()
        {
            // Padding (p-*)
            ["p-0"] = c => c.Padding = new Thickness(0),
            ["p-px"] = c => c.Padding = new Thickness(1),
            ["p-0.5"] = c => c.Padding = new Thickness(2),
            ["p-1"] = c => c.Padding = new Thickness(4),
            ["p-1.5"] = c => c.Padding = new Thickness(6),
            ["p-2"] = c => c.Padding = new Thickness(8),
            ["p-2.5"] = c => c.Padding = new Thickness(10),
            ["p-3"] = c => c.Padding = new Thickness(12),
            ["p-3.5"] = c => c.Padding = new Thickness(14),
            ["p-4"] = c => c.Padding = new Thickness(16),
            ["p-5"] = c => c.Padding = new Thickness(20),
            ["p-6"] = c => c.Padding = new Thickness(24),
            ["p-7"] = c => c.Padding = new Thickness(28),
            ["p-8"] = c => c.Padding = new Thickness(32),
            ["p-9"] = c => c.Padding = new Thickness(36),
            ["p-10"] = c => c.Padding = new Thickness(40),
            ["p-11"] = c => c.Padding = new Thickness(44),
            ["p-12"] = c => c.Padding = new Thickness(48),

            // Padding Horizontal (px-*)
            ["px-0"] = c => c.Padding = new Thickness(0, c.Padding.Top, 0, c.Padding.Bottom),
            ["px-1"] = c => c.Padding = new Thickness(4, c.Padding.Top, 4, c.Padding.Bottom),
            ["px-2"] = c => c.Padding = new Thickness(8, c.Padding.Top, 8, c.Padding.Bottom),
            ["px-3"] = c => c.Padding = new Thickness(12, c.Padding.Top, 12, c.Padding.Bottom),
            ["px-4"] = c => c.Padding = new Thickness(16, c.Padding.Top, 16, c.Padding.Bottom),
            ["px-5"] = c => c.Padding = new Thickness(20, c.Padding.Top, 20, c.Padding.Bottom),
            ["px-6"] = c => c.Padding = new Thickness(24, c.Padding.Top, 24, c.Padding.Bottom),
            ["px-8"] = c => c.Padding = new Thickness(32, c.Padding.Top, 32, c.Padding.Bottom),

            // Padding Vertical (py-*)
            ["py-0"] = c => c.Padding = new Thickness(c.Padding.Left, 0, c.Padding.Right, 0),
            ["py-1"] = c => c.Padding = new Thickness(c.Padding.Left, 4, c.Padding.Right, 4),
            ["py-2"] = c => c.Padding = new Thickness(c.Padding.Left, 8, c.Padding.Right, 8),
            ["py-3"] = c => c.Padding = new Thickness(c.Padding.Left, 12, c.Padding.Right, 12),
            ["py-4"] = c => c.Padding = new Thickness(c.Padding.Left, 16, c.Padding.Right, 16),
            ["py-5"] = c => c.Padding = new Thickness(c.Padding.Left, 20, c.Padding.Right, 20),
            ["py-6"] = c => c.Padding = new Thickness(c.Padding.Left, 24, c.Padding.Right, 24),
            ["py-8"] = c => c.Padding = new Thickness(c.Padding.Left, 32, c.Padding.Right, 32),

            // Margin (m-*)
            ["m-0"] = c => c.Margin = new Thickness(0),
            ["m-px"] = c => c.Margin = new Thickness(1),
            ["m-0.5"] = c => c.Margin = new Thickness(2),
            ["m-1"] = c => c.Margin = new Thickness(4),
            ["m-1.5"] = c => c.Margin = new Thickness(6),
            ["m-2"] = c => c.Margin = new Thickness(8),
            ["m-2.5"] = c => c.Margin = new Thickness(10),
            ["m-3"] = c => c.Margin = new Thickness(12),
            ["m-3.5"] = c => c.Margin = new Thickness(14),
            ["m-4"] = c => c.Margin = new Thickness(16),
            ["m-5"] = c => c.Margin = new Thickness(20),
            ["m-6"] = c => c.Margin = new Thickness(24),
            ["m-8"] = c => c.Margin = new Thickness(32),
            ["m-10"] = c => c.Margin = new Thickness(40),
            ["m-12"] = c => c.Margin = new Thickness(48),

            // Margin Auto
            ["m-auto"] = c => c.HorizontalAlignment = HorizontalAlignment.Center,
            ["mx-auto"] = c => c.HorizontalAlignment = HorizontalAlignment.Center,
            ["my-auto"] = c => c.VerticalAlignment = VerticalAlignment.Center,
        };
    }
}
