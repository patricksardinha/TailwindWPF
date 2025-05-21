using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TailwindWPF.Styling.Styles
{
    public class CommonStyles
    {
        public static readonly Dictionary<string, Action<Control>> Map = new()
        {
            // Background colors
            ["bg-blue-500"] = c => c.Background = new SolidColorBrush((Color) ColorConverter.ConvertFromString("#3B82F6")),
            ["bg-red-500"] = c => c.Background = new SolidColorBrush((Color) ColorConverter.ConvertFromString("#EF4444")),

            // Text
            ["text-white"] = c => c.Foreground = Brushes.White,
            ["text-black"] = c => c.Foreground = Brushes.Black,
            ["text-lg"] = c => c.FontSize = 18,
            ["text-sm"] = c => c.FontSize = 12,

            // Padding
            ["p-1"] = c => c.Padding = new Thickness(4),
            ["p-2"] = c => c.Padding = new Thickness(8),
            ["p-3"] = c => c.Padding = new Thickness(12),
            ["p-4"] = c => c.Padding = new Thickness(16),

            // Rounded corners
            ["rounded"] = c => CornerRadiusHelper.SetCornerRadius(c, new CornerRadius(8)),
            ["rounded-sm"] = c => CornerRadiusHelper.SetCornerRadius(c, new CornerRadius(4)),
            ["rounded-lg"] = c => CornerRadiusHelper.SetCornerRadius(c, new CornerRadius(12)),

            // Margin
            ["m-1"] = c => c.Margin = new Thickness(4),
            ["m-2"] = c => c.Margin = new Thickness(8),
            ["m-3"] = c => c.Margin = new Thickness(12),
            ["m-4"] = c => c.Margin = new Thickness(16)
        };
}
}
