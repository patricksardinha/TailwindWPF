using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TailwindWPF.Styling.Styles
{
    public class BackgroundStyles : BaseStyleProvider
    {
        public override Dictionary<string, Action<DependencyObject>> GetStyles() => new()
        {
            // Grays
            ["bg-gray-50"] = SetBackground("#F9FAFB"),
            ["bg-gray-100"] = SetBackground("#F3F4F6"),
            ["bg-gray-200"] = SetBackground("#E5E7EB"),
            ["bg-gray-300"] = SetBackground("#D1D5DB"),
            ["bg-gray-400"] = SetBackground("#9CA3AF"),
            ["bg-gray-500"] = SetBackground("#6B7280"),
            ["bg-gray-600"] = SetBackground("#4B5563"),
            ["bg-gray-700"] = SetBackground("#374151"),
            ["bg-gray-800"] = SetBackground("#1F2937"),
            ["bg-gray-900"] = SetBackground("#111827"),

            // Blues
            ["bg-blue-50"] = SetBackground("#EFF6FF"),
            ["bg-blue-100"] = SetBackground("#DBEAFE"),
            ["bg-blue-200"] = SetBackground("#BFDBFE"),
            ["bg-blue-300"] = SetBackground("#93C5FD"),
            ["bg-blue-400"] = SetBackground("#60A5FA"),
            ["bg-blue-500"] = SetBackground("#3B82F6"),
            ["bg-blue-600"] = SetBackground("#2563EB"),
            ["bg-blue-700"] = SetBackground("#1D4ED8"),
            ["bg-blue-800"] = SetBackground("#1E40AF"),
            ["bg-blue-900"] = SetBackground("#1E3A8A"),

            // Reds
            ["bg-red-50"] = SetBackground("#FEF2F2"),
            ["bg-red-100"] = SetBackground("#FEE2E2"),
            ["bg-red-200"] = SetBackground("#FECACA"),
            ["bg-red-300"] = SetBackground("#FCA5A5"),
            ["bg-red-400"] = SetBackground("#F87171"),
            ["bg-red-500"] = SetBackground("#EF4444"),
            ["bg-red-600"] = SetBackground("#DC2626"),
            ["bg-red-700"] = SetBackground("#B91C1C"),
            ["bg-red-800"] = SetBackground("#991B1B"),
            ["bg-red-900"] = SetBackground("#7F1D1D"),

            // Greens
            ["bg-green-50"] = SetBackground("#F0FDF4"),
            ["bg-green-100"] = SetBackground("#DCFCE7"),
            ["bg-green-200"] = SetBackground("#BBF7D0"),
            ["bg-green-300"] = SetBackground("#86EFAC"),
            ["bg-green-400"] = SetBackground("#4ADE80"),
            ["bg-green-500"] = SetBackground("#22C55E"),
            ["bg-green-600"] = SetBackground("#16A34A"),
            ["bg-green-700"] = SetBackground("#15803D"),
            ["bg-green-800"] = SetBackground("#166534"),
            ["bg-green-900"] = SetBackground("#14532D"),

            // Transparent & Special
            ["bg-transparent"] = d =>
            {
                if (d is Control c) c.Background = Brushes.Transparent;
                else if (d is Border b) b.Background = Brushes.Transparent;
            },

            ["bg-current"] = d =>
            {
                if (d is Control c) c.Background = c.Foreground;
                else if (d is Border b) b.Background = Brushes.Black;
            },

            ["bg-white"] = d =>
            {
                if (d is Control c) c.Background = Brushes.White;
                else if (d is Border b) b.Background = Brushes.White;
            },

            ["bg-black"] = d =>
            {
                if (d is Control c) c.Background = Brushes.Black;
                else if (d is Border b) b.Background = Brushes.Black;
            },
        };

        private static Action<DependencyObject> SetBackground(string hex) =>
            d =>
            {
                var brush = CreateBrush(hex);
                if (d is Control c) c.Background = brush;
                else if (d is Border b) b.Background = brush;
            };
    }

}
