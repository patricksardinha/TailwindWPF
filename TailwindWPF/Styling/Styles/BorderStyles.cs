using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace TailwindWPF.Styling.Styles
{
    public class BorderStyles : BaseStyleProvider
    {
        public override Dictionary<string, Action<Control>> GetStyles() => new()
        {
            // Border Width
            ["border-0"] = c => c.BorderThickness = new Thickness(0),
            ["border"] = c => c.BorderThickness = new Thickness(1),
            ["border-2"] = c => c.BorderThickness = new Thickness(2),
            ["border-4"] = c => c.BorderThickness = new Thickness(4),
            ["border-8"] = c => c.BorderThickness = new Thickness(8),

            // Border Colors
            ["border-transparent"] = c => c.BorderBrush = Brushes.Transparent,
            ["border-current"] = c => c.BorderBrush = c.Foreground,
            ["border-black"] = c => c.BorderBrush = Brushes.Black,
            ["border-white"] = c => c.BorderBrush = Brushes.White,
            ["border-gray-50"] = c => c.BorderBrush = CreateBrush("#F9FAFB"),
            ["border-gray-100"] = c => c.BorderBrush = CreateBrush("#F3F4F6"),
            ["border-gray-200"] = c => c.BorderBrush = CreateBrush("#E5E7EB"),
            ["border-gray-300"] = c => c.BorderBrush = CreateBrush("#D1D5DB"),
            ["border-gray-400"] = c => c.BorderBrush = CreateBrush("#9CA3AF"),
            ["border-gray-500"] = c => c.BorderBrush = CreateBrush("#6B7280"),

            // Rounded corners
            ["rounded-none"] = c => CornerRadiusHelper.SetCornerRadius(c, new CornerRadius(0)),
            ["rounded-sm"] = c => CornerRadiusHelper.SetCornerRadius(c, new CornerRadius(2)),
            ["rounded"] = c => CornerRadiusHelper.SetCornerRadius(c, new CornerRadius(4)),
            ["rounded-md"] = c => CornerRadiusHelper.SetCornerRadius(c, new CornerRadius(6)),
            ["rounded-lg"] = c => CornerRadiusHelper.SetCornerRadius(c, new CornerRadius(8)),
            ["rounded-xl"] = c => CornerRadiusHelper.SetCornerRadius(c, new CornerRadius(12)),
            ["rounded-2xl"] = c => CornerRadiusHelper.SetCornerRadius(c, new CornerRadius(16)),
            ["rounded-3xl"] = c => CornerRadiusHelper.SetCornerRadius(c, new CornerRadius(24)),
            ["rounded-full"] = c => CornerRadiusHelper.SetCornerRadius(c, new CornerRadius(9999)),
        };
    }
}
