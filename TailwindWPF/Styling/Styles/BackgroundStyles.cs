using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace TailwindWPF.Styling.Styles
{
    public class BackgroundStyles : BaseStyleProvider
    {
        public override Dictionary<string, Action<Control>> GetStyles() => new()
        {
            // Grays
            ["bg-gray-50"] = c => c.Background = CreateBrush("#F9FAFB"),
            ["bg-gray-100"] = c => c.Background = CreateBrush("#F3F4F6"),
            ["bg-gray-200"] = c => c.Background = CreateBrush("#E5E7EB"),
            ["bg-gray-300"] = c => c.Background = CreateBrush("#D1D5DB"),
            ["bg-gray-400"] = c => c.Background = CreateBrush("#9CA3AF"),
            ["bg-gray-500"] = c => c.Background = CreateBrush("#6B7280"),
            ["bg-gray-600"] = c => c.Background = CreateBrush("#4B5563"),
            ["bg-gray-700"] = c => c.Background = CreateBrush("#374151"),
            ["bg-gray-800"] = c => c.Background = CreateBrush("#1F2937"),
            ["bg-gray-900"] = c => c.Background = CreateBrush("#111827"),

            // Blues
            ["bg-blue-50"] = c => c.Background = CreateBrush("#EFF6FF"),
            ["bg-blue-100"] = c => c.Background = CreateBrush("#DBEAFE"),
            ["bg-blue-200"] = c => c.Background = CreateBrush("#BFDBFE"),
            ["bg-blue-300"] = c => c.Background = CreateBrush("#93C5FD"),
            ["bg-blue-400"] = c => c.Background = CreateBrush("#60A5FA"),
            ["bg-blue-500"] = c => c.Background = CreateBrush("#3B82F6"),
            ["bg-blue-600"] = c => c.Background = CreateBrush("#2563EB"),
            ["bg-blue-700"] = c => c.Background = CreateBrush("#1D4ED8"),
            ["bg-blue-800"] = c => c.Background = CreateBrush("#1E40AF"),
            ["bg-blue-900"] = c => c.Background = CreateBrush("#1E3A8A"),

            // Reds
            ["bg-red-50"] = c => c.Background = CreateBrush("#FEF2F2"),
            ["bg-red-100"] = c => c.Background = CreateBrush("#FEE2E2"),
            ["bg-red-200"] = c => c.Background = CreateBrush("#FECACA"),
            ["bg-red-300"] = c => c.Background = CreateBrush("#FCA5A5"),
            ["bg-red-400"] = c => c.Background = CreateBrush("#F87171"),
            ["bg-red-500"] = c => c.Background = CreateBrush("#EF4444"),
            ["bg-red-600"] = c => c.Background = CreateBrush("#DC2626"),
            ["bg-red-700"] = c => c.Background = CreateBrush("#B91C1C"),
            ["bg-red-800"] = c => c.Background = CreateBrush("#991B1B"),
            ["bg-red-900"] = c => c.Background = CreateBrush("#7F1D1D"),

            // Greens
            ["bg-green-50"] = c => c.Background = CreateBrush("#F0FDF4"),
            ["bg-green-100"] = c => c.Background = CreateBrush("#DCFCE7"),
            ["bg-green-200"] = c => c.Background = CreateBrush("#BBF7D0"),
            ["bg-green-300"] = c => c.Background = CreateBrush("#86EFAC"),
            ["bg-green-400"] = c => c.Background = CreateBrush("#4ADE80"),
            ["bg-green-500"] = c => c.Background = CreateBrush("#22C55E"),
            ["bg-green-600"] = c => c.Background = CreateBrush("#16A34A"),
            ["bg-green-700"] = c => c.Background = CreateBrush("#15803D"),
            ["bg-green-800"] = c => c.Background = CreateBrush("#166534"),
            ["bg-green-900"] = c => c.Background = CreateBrush("#14532D"),

            // Transparent & Special
            ["bg-transparent"] = c => c.Background = Brushes.Transparent,
            ["bg-current"] = c => c.Background = c.Foreground,
            ["bg-white"] = c => c.Background = Brushes.White,
            ["bg-black"] = c => c.Background = Brushes.Black,
        };
    }
}
