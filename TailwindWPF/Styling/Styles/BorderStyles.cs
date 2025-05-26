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
        public override Dictionary<string, Action<DependencyObject>> GetStyles() => new()
        {
            // Border Width
            ["border-0"] = d => SetThickness(d, 0),
            ["border"] = d => SetThickness(d, 1),
            ["border-2"] = d => SetThickness(d, 2),
            ["border-4"] = d => SetThickness(d, 4),
            ["border-8"] = d => SetThickness(d, 8),

            // Border Colors
            ["border-transparent"] = SetBorderBrush(Brushes.Transparent),
            ["border-current"] = d =>
            {
                if (d is Control c) c.BorderBrush = c.Foreground;
                else if (d is Border b) b.BorderBrush = Brushes.Black;
            },
            ["border-black"] = SetBorderBrush(Brushes.Black),
            ["border-white"] = SetBorderBrush(Brushes.White),
            ["border-gray-50"] = SetBorderBrush(CreateBrush("#F9FAFB")),
            ["border-gray-100"] = SetBorderBrush(CreateBrush("#F3F4F6")),
            ["border-gray-200"] = SetBorderBrush(CreateBrush("#E5E7EB")),
            ["border-gray-300"] = SetBorderBrush(CreateBrush("#D1D5DB")),
            ["border-gray-400"] = SetBorderBrush(CreateBrush("#9CA3AF")),
            ["border-gray-500"] = SetBorderBrush(CreateBrush("#6B7280")),

            // Rounded corners
            ["rounded-none"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(0)),
            ["rounded-sm"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(2)),
            ["rounded"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(4)),
            ["rounded-md"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(6)),
            ["rounded-lg"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(8)),
            ["rounded-xl"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(12)),
            ["rounded-2xl"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(16)),
            ["rounded-3xl"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(24)),
            ["rounded-full"] = d => CornerRadiusHelper.SetCornerRadius(d, new CornerRadius(9999)),
        };

        private static void SetThickness(DependencyObject d, double value)
        {
            var thickness = new Thickness(value);
            if (d is Control c) c.BorderThickness = thickness;
            else if (d is Border b) b.BorderThickness = thickness;
        }

        private static Action<DependencyObject> SetBorderBrush(Brush brush) =>
            d =>
            {
                if (d is Control c) c.BorderBrush = brush;
                else if (d is Border b) b.BorderBrush = brush;
            };
    }

}
