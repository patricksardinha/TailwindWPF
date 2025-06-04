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

            // Yellow
            ["bg-yellow-50"] = SetBackground("#FFFBEB"),
            ["bg-yellow-100"] = SetBackground("#FEF3C7"),
            ["bg-yellow-200"] = SetBackground("#FDE68A"),
            ["bg-yellow-300"] = SetBackground("#FCD34D"),
            ["bg-yellow-400"] = SetBackground("#FBBF24"),
            ["bg-yellow-500"] = SetBackground("#F59E0B"),
            ["bg-yellow-600"] = SetBackground("#D97706"),
            ["bg-yellow-700"] = SetBackground("#B45309"),
            ["bg-yellow-800"] = SetBackground("#92400E"),
            ["bg-yellow-900"] = SetBackground("#78350F"),

            // Purple
            ["bg-purple-50"] = SetBackground("#FAF5FF"),
            ["bg-purple-100"] = SetBackground("#F3E8FF"),
            ["bg-purple-200"] = SetBackground("#E9D5FF"),
            ["bg-purple-300"] = SetBackground("#D8B4FE"),
            ["bg-purple-400"] = SetBackground("#C084FC"),
            ["bg-purple-500"] = SetBackground("#A855F7"),
            ["bg-purple-600"] = SetBackground("#9333EA"),
            ["bg-purple-700"] = SetBackground("#7C3AED"),
            ["bg-purple-800"] = SetBackground("#6B21A8"),
            ["bg-purple-900"] = SetBackground("#581C87"),

            // Pink
            ["bg-pink-50"] = SetBackground("#FDF2F8"),
            ["bg-pink-100"] = SetBackground("#FCE7F3"),
            ["bg-pink-200"] = SetBackground("#FBCFE8"),
            ["bg-pink-300"] = SetBackground("#F9A8D4"),
            ["bg-pink-400"] = SetBackground("#F472B6"),
            ["bg-pink-500"] = SetBackground("#EC4899"),
            ["bg-pink-600"] = SetBackground("#DB2777"),
            ["bg-pink-700"] = SetBackground("#BE185D"),
            ["bg-pink-800"] = SetBackground("#9D174D"),
            ["bg-pink-900"] = SetBackground("#831843"),

            // Indigo
            ["bg-indigo-50"] = SetBackground("#EEF2FF"),
            ["bg-indigo-100"] = SetBackground("#E0E7FF"),
            ["bg-indigo-200"] = SetBackground("#C7D2FE"),
            ["bg-indigo-300"] = SetBackground("#A5B4FC"),
            ["bg-indigo-400"] = SetBackground("#818CF8"),
            ["bg-indigo-500"] = SetBackground("#6366F1"),
            ["bg-indigo-600"] = SetBackground("#4F46E5"),
            ["bg-indigo-700"] = SetBackground("#4338CA"),
            ["bg-indigo-800"] = SetBackground("#3730A3"),
            ["bg-indigo-900"] = SetBackground("#312E81"),

            // Orange
            ["bg-orange-50"] = SetBackground("#FFF7ED"),
            ["bg-orange-100"] = SetBackground("#FFEDD5"),
            ["bg-orange-200"] = SetBackground("#FED7AA"),
            ["bg-orange-300"] = SetBackground("#FDBA74"),
            ["bg-orange-400"] = SetBackground("#FB923C"),
            ["bg-orange-500"] = SetBackground("#F97316"),
            ["bg-orange-600"] = SetBackground("#EA580C"),
            ["bg-orange-700"] = SetBackground("#C2410C"),
            ["bg-orange-800"] = SetBackground("#9A3412"),
            ["bg-orange-900"] = SetBackground("#7C2D12"),

            // Teal
            ["bg-teal-50"] = SetBackground("#F0FDFA"),
            ["bg-teal-100"] = SetBackground("#CCFBF1"),
            ["bg-teal-200"] = SetBackground("#99F6E4"),
            ["bg-teal-300"] = SetBackground("#5EEAD4"),
            ["bg-teal-400"] = SetBackground("#2DD4BF"),
            ["bg-teal-500"] = SetBackground("#14B8A6"),
            ["bg-teal-600"] = SetBackground("#0D9488"),
            ["bg-teal-700"] = SetBackground("#0F766E"),
            ["bg-teal-800"] = SetBackground("#115E59"),
            ["bg-teal-900"] = SetBackground("#134E4A"),

            // Cyan
            ["bg-cyan-50"] = SetBackground("#ECFEFF"),
            ["bg-cyan-100"] = SetBackground("#CFFAFE"),
            ["bg-cyan-200"] = SetBackground("#A5F3FC"),
            ["bg-cyan-300"] = SetBackground("#67E8F9"),
            ["bg-cyan-400"] = SetBackground("#22D3EE"),
            ["bg-cyan-500"] = SetBackground("#06B6D4"),
            ["bg-cyan-600"] = SetBackground("#0891B2"),
            ["bg-cyan-700"] = SetBackground("#0E7490"),
            ["bg-cyan-800"] = SetBackground("#155E75"),
            ["bg-cyan-900"] = SetBackground("#164E63"),

            // Emerald
            ["bg-emerald-50"] = SetBackground("#ECFDF5"),
            ["bg-emerald-100"] = SetBackground("#D1FAE5"),
            ["bg-emerald-200"] = SetBackground("#A7F3D0"),
            ["bg-emerald-300"] = SetBackground("#6EE7B7"),
            ["bg-emerald-400"] = SetBackground("#34D399"),
            ["bg-emerald-500"] = SetBackground("#10B981"),
            ["bg-emerald-600"] = SetBackground("#059669"),
            ["bg-emerald-700"] = SetBackground("#047857"),
            ["bg-emerald-800"] = SetBackground("#065F46"),
            ["bg-emerald-900"] = SetBackground("#064E3B"),

            // Lime
            ["bg-lime-50"] = SetBackground("#F7FEE7"),
            ["bg-lime-100"] = SetBackground("#ECFCCB"),
            ["bg-lime-200"] = SetBackground("#D9F99D"),
            ["bg-lime-300"] = SetBackground("#BEF264"),
            ["bg-lime-400"] = SetBackground("#A3E635"),
            ["bg-lime-500"] = SetBackground("#84CC16"),
            ["bg-lime-600"] = SetBackground("#65A30D"),
            ["bg-lime-700"] = SetBackground("#4D7C0F"),
            ["bg-lime-800"] = SetBackground("#365314"),
            ["bg-lime-900"] = SetBackground("#1A2E05"),

            // Rose
            ["bg-rose-50"] = SetBackground("#FFF1F2"),
            ["bg-rose-100"] = SetBackground("#FFE4E6"),
            ["bg-rose-200"] = SetBackground("#FECDD3"),
            ["bg-rose-300"] = SetBackground("#FDA4AF"),
            ["bg-rose-400"] = SetBackground("#FB7185"),
            ["bg-rose-500"] = SetBackground("#F43F5E"),
            ["bg-rose-600"] = SetBackground("#E11D48"),
            ["bg-rose-700"] = SetBackground("#BE123C"),
            ["bg-rose-800"] = SetBackground("#9F1239"),
            ["bg-rose-900"] = SetBackground("#881337"),

            // Slate
            ["bg-slate-50"] = SetBackground("#F8FAFC"),
            ["bg-slate-100"] = SetBackground("#F1F5F9"),
            ["bg-slate-200"] = SetBackground("#E2E8F0"),
            ["bg-slate-300"] = SetBackground("#CBD5E1"),
            ["bg-slate-400"] = SetBackground("#94A3B8"),
            ["bg-slate-500"] = SetBackground("#64748B"),
            ["bg-slate-600"] = SetBackground("#475569"),
            ["bg-slate-700"] = SetBackground("#334155"),
            ["bg-slate-800"] = SetBackground("#1E293B"),
            ["bg-slate-900"] = SetBackground("#0F172A"),

            // Zinc
            ["bg-zinc-50"] = SetBackground("#FAFAFA"),
            ["bg-zinc-100"] = SetBackground("#F4F4F5"),
            ["bg-zinc-200"] = SetBackground("#E4E4E7"),
            ["bg-zinc-300"] = SetBackground("#D4D4D8"),
            ["bg-zinc-400"] = SetBackground("#A1A1AA"),
            ["bg-zinc-500"] = SetBackground("#71717A"),
            ["bg-zinc-600"] = SetBackground("#52525B"),
            ["bg-zinc-700"] = SetBackground("#3F3F46"),
            ["bg-zinc-800"] = SetBackground("#27272A"),
            ["bg-zinc-900"] = SetBackground("#18181B"),

            // Neutral
            ["bg-neutral-50"] = SetBackground("#FAFAFA"),
            ["bg-neutral-100"] = SetBackground("#F5F5F5"),
            ["bg-neutral-200"] = SetBackground("#E5E5E5"),
            ["bg-neutral-300"] = SetBackground("#D4D4D4"),
            ["bg-neutral-400"] = SetBackground("#A3A3A3"),
            ["bg-neutral-500"] = SetBackground("#737373"),
            ["bg-neutral-600"] = SetBackground("#525252"),
            ["bg-neutral-700"] = SetBackground("#404040"),
            ["bg-neutral-800"] = SetBackground("#262626"),
            ["bg-neutral-900"] = SetBackground("#171717"),

            // Stone
            ["bg-stone-50"] = SetBackground("#FAFAF9"),
            ["bg-stone-100"] = SetBackground("#F5F5F4"),
            ["bg-stone-200"] = SetBackground("#E7E5E4"),
            ["bg-stone-300"] = SetBackground("#D6D3D1"),
            ["bg-stone-400"] = SetBackground("#A8A29E"),
            ["bg-stone-500"] = SetBackground("#78716C"),
            ["bg-stone-600"] = SetBackground("#57534E"),
            ["bg-stone-700"] = SetBackground("#44403C"),
            ["bg-stone-800"] = SetBackground("#292524"),
            ["bg-stone-900"] = SetBackground("#1C1917"),

            // Sky
            ["bg-sky-50"] = SetBackground("#F0F9FF"),
            ["bg-sky-100"] = SetBackground("#E0F2FE"),
            ["bg-sky-200"] = SetBackground("#BAE6FD"),
            ["bg-sky-300"] = SetBackground("#7DD3FC"),
            ["bg-sky-400"] = SetBackground("#38BDF8"),
            ["bg-sky-500"] = SetBackground("#0EA5E9"),
            ["bg-sky-600"] = SetBackground("#0284C7"),
            ["bg-sky-700"] = SetBackground("#0369A1"),
            ["bg-sky-800"] = SetBackground("#075985"),
            ["bg-sky-900"] = SetBackground("#0C4A6E"),

            // Violet
            ["bg-violet-50"] = SetBackground("#F5F3FF"),
            ["bg-violet-100"] = SetBackground("#EDE9FE"),
            ["bg-violet-200"] = SetBackground("#DDD6FE"),
            ["bg-violet-300"] = SetBackground("#C4B5FD"),
            ["bg-violet-400"] = SetBackground("#A78BFA"),
            ["bg-violet-500"] = SetBackground("#8B5CF6"),
            ["bg-violet-600"] = SetBackground("#7C3AED"),
            ["bg-violet-700"] = SetBackground("#6D28D9"),
            ["bg-violet-800"] = SetBackground("#5B21B6"),
            ["bg-violet-900"] = SetBackground("#4C1D95"),

            // Fuchsia
            ["bg-fuchsia-50"] = SetBackground("#FDF4FF"),
            ["bg-fuchsia-100"] = SetBackground("#FAE8FF"),
            ["bg-fuchsia-200"] = SetBackground("#F5D0FE"),
            ["bg-fuchsia-300"] = SetBackground("#F0ABFC"),
            ["bg-fuchsia-400"] = SetBackground("#E879F9"),
            ["bg-fuchsia-500"] = SetBackground("#D946EF"),
            ["bg-fuchsia-600"] = SetBackground("#C026D3"),
            ["bg-fuchsia-700"] = SetBackground("#A21CAF"),
            ["bg-fuchsia-800"] = SetBackground("#86198F"),
            ["bg-fuchsia-900"] = SetBackground("#701A75"),

            // Amber
            ["bg-amber-50"] = SetBackground("#FFFBEB"),
            ["bg-amber-100"] = SetBackground("#FEF3C7"),
            ["bg-amber-200"] = SetBackground("#FDE68A"),
            ["bg-amber-300"] = SetBackground("#FCD34D"),
            ["bg-amber-400"] = SetBackground("#FBBF24"),
            ["bg-amber-500"] = SetBackground("#F59E0B"),
            ["bg-amber-600"] = SetBackground("#D97706"),
            ["bg-amber-700"] = SetBackground("#B45309"),
            ["bg-amber-800"] = SetBackground("#92400E"),
            ["bg-amber-900"] = SetBackground("#78350F"),

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
