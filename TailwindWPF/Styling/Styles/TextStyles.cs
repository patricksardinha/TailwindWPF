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
    public class TextStyles : BaseStyleProvider
    {
        public override Dictionary<string, Action<DependencyObject>> GetStyles() => new()
        {
            // Text Colors
            ["text-white"] = e => SetForeground(e, Brushes.White),
            ["text-black"] = e => SetForeground(e, Brushes.Black),

            // Gray Text
            ["text-gray-50"] = e => SetForeground(e, "#F9FAFB"),
            ["text-gray-100"] = e => SetForeground(e, "#F3F4F6"),
            ["text-gray-200"] = e => SetForeground(e, "#E5E7EB"),
            ["text-gray-300"] = e => SetForeground(e, "#D1D5DB"),
            ["text-gray-400"] = e => SetForeground(e, "#9CA3AF"),
            ["text-gray-500"] = e => SetForeground(e, "#6B7280"),
            ["text-gray-600"] = e => SetForeground(e, "#4B5563"),
            ["text-gray-700"] = e => SetForeground(e, "#374151"),
            ["text-gray-800"] = e => SetForeground(e, "#1F2937"),
            ["text-gray-900"] = e => SetForeground(e, "#111827"),

            // Yellow Text
            ["text-yellow-50"] = e => SetForeground(e, "#FFFBEB"),
            ["text-yellow-100"] = e => SetForeground(e, "#FEF3C7"),
            ["text-yellow-200"] = e => SetForeground(e, "#FDE68A"),
            ["text-yellow-300"] = e => SetForeground(e, "#FCD34D"),
            ["text-yellow-400"] = e => SetForeground(e, "#FBBF24"),
            ["text-yellow-500"] = e => SetForeground(e, "#F59E0B"),
            ["text-yellow-600"] = e => SetForeground(e, "#D97706"),
            ["text-yellow-700"] = e => SetForeground(e, "#B45309"),
            ["text-yellow-800"] = e => SetForeground(e, "#92400E"),
            ["text-yellow-900"] = e => SetForeground(e, "#78350F"),

            // Purple Text
            ["text-purple-50"] = e => SetForeground(e, "#FAF5FF"),
            ["text-purple-100"] = e => SetForeground(e, "#F3E8FF"),
            ["text-purple-200"] = e => SetForeground(e, "#E9D5FF"),
            ["text-purple-300"] = e => SetForeground(e, "#D8B4FE"),
            ["text-purple-400"] = e => SetForeground(e, "#C084FC"),
            ["text-purple-500"] = e => SetForeground(e, "#A855F7"),
            ["text-purple-600"] = e => SetForeground(e, "#9333EA"),
            ["text-purple-700"] = e => SetForeground(e, "#7C3AED"),
            ["text-purple-800"] = e => SetForeground(e, "#6B21A8"),
            ["text-purple-900"] = e => SetForeground(e, "#581C87"),

            // Pink Text
            ["text-pink-50"] = e => SetForeground(e, "#FDF2F8"),
            ["text-pink-100"] = e => SetForeground(e, "#FCE7F3"),
            ["text-pink-200"] = e => SetForeground(e, "#FBCFE8"),
            ["text-pink-300"] = e => SetForeground(e, "#F9A8D4"),
            ["text-pink-400"] = e => SetForeground(e, "#F472B6"),
            ["text-pink-500"] = e => SetForeground(e, "#EC4899"),
            ["text-pink-600"] = e => SetForeground(e, "#DB2777"),
            ["text-pink-700"] = e => SetForeground(e, "#BE185D"),
            ["text-pink-800"] = e => SetForeground(e, "#9D174D"),
            ["text-pink-900"] = e => SetForeground(e, "#831843"),

            // Indigo Text
            ["text-indigo-50"] = e => SetForeground(e, "#EEF2FF"),
            ["text-indigo-100"] = e => SetForeground(e, "#E0E7FF"),
            ["text-indigo-200"] = e => SetForeground(e, "#C7D2FE"),
            ["text-indigo-300"] = e => SetForeground(e, "#A5B4FC"),
            ["text-indigo-400"] = e => SetForeground(e, "#818CF8"),
            ["text-indigo-500"] = e => SetForeground(e, "#6366F1"),
            ["text-indigo-600"] = e => SetForeground(e, "#4F46E5"),
            ["text-indigo-700"] = e => SetForeground(e, "#4338CA"),
            ["text-indigo-800"] = e => SetForeground(e, "#3730A3"),
            ["text-indigo-900"] = e => SetForeground(e, "#312E81"),

            // Orange Text
            ["text-orange-50"] = e => SetForeground(e, "#FFF7ED"),
            ["text-orange-100"] = e => SetForeground(e, "#FFEDD5"),
            ["text-orange-200"] = e => SetForeground(e, "#FED7AA"),
            ["text-orange-300"] = e => SetForeground(e, "#FDBA74"),
            ["text-orange-400"] = e => SetForeground(e, "#FB923C"),
            ["text-orange-500"] = e => SetForeground(e, "#F97316"),
            ["text-orange-600"] = e => SetForeground(e, "#EA580C"),
            ["text-orange-700"] = e => SetForeground(e, "#C2410C"),
            ["text-orange-800"] = e => SetForeground(e, "#9A3412"),
            ["text-orange-900"] = e => SetForeground(e, "#7C2D12"),

            // Teal Text
            ["text-teal-50"] = e => SetForeground(e, "#F0FDFA"),
            ["text-teal-100"] = e => SetForeground(e, "#CCFBF1"),
            ["text-teal-200"] = e => SetForeground(e, "#99F6E4"),
            ["text-teal-300"] = e => SetForeground(e, "#5EEAD4"),
            ["text-teal-400"] = e => SetForeground(e, "#2DD4BF"),
            ["text-teal-500"] = e => SetForeground(e, "#14B8A6"),
            ["text-teal-600"] = e => SetForeground(e, "#0D9488"),
            ["text-teal-700"] = e => SetForeground(e, "#0F766E"),
            ["text-teal-800"] = e => SetForeground(e, "#115E59"),
            ["text-teal-900"] = e => SetForeground(e, "#134E4A"),

            // Cyan Text
            ["text-cyan-50"] = e => SetForeground(e, "#ECFEFF"),
            ["text-cyan-100"] = e => SetForeground(e, "#CFFAFE"),
            ["text-cyan-200"] = e => SetForeground(e, "#A5F3FC"),
            ["text-cyan-300"] = e => SetForeground(e, "#67E8F9"),
            ["text-cyan-400"] = e => SetForeground(e, "#22D3EE"),
            ["text-cyan-500"] = e => SetForeground(e, "#06B6D4"),
            ["text-cyan-600"] = e => SetForeground(e, "#0891B2"),
            ["text-cyan-700"] = e => SetForeground(e, "#0E7490"),
            ["text-cyan-800"] = e => SetForeground(e, "#155E75"),
            ["text-cyan-900"] = e => SetForeground(e, "#164E63"),

            // Emerald Text
            ["text-emerald-50"] = e => SetForeground(e, "#ECFDF5"),
            ["text-emerald-100"] = e => SetForeground(e, "#D1FAE5"),
            ["text-emerald-200"] = e => SetForeground(e, "#A7F3D0"),
            ["text-emerald-300"] = e => SetForeground(e, "#6EE7B7"),
            ["text-emerald-400"] = e => SetForeground(e, "#34D399"),
            ["text-emerald-500"] = e => SetForeground(e, "#10B981"),
            ["text-emerald-600"] = e => SetForeground(e, "#059669"),
            ["text-emerald-700"] = e => SetForeground(e, "#047857"),
            ["text-emerald-800"] = e => SetForeground(e, "#065F46"),
            ["text-emerald-900"] = e => SetForeground(e, "#064E3B"),

            // Lime Text
            ["text-lime-50"] = e => SetForeground(e, "#F7FEE7"),
            ["text-lime-100"] = e => SetForeground(e, "#ECFCCB"),
            ["text-lime-200"] = e => SetForeground(e, "#D9F99D"),
            ["text-lime-300"] = e => SetForeground(e, "#BEF264"),
            ["text-lime-400"] = e => SetForeground(e, "#A3E635"),
            ["text-lime-500"] = e => SetForeground(e, "#84CC16"),
            ["text-lime-600"] = e => SetForeground(e, "#65A30D"),
            ["text-lime-700"] = e => SetForeground(e, "#4D7C0F"),
            ["text-lime-800"] = e => SetForeground(e, "#365314"),
            ["text-lime-900"] = e => SetForeground(e, "#1A2E05"),

            // Rose Text
            ["text-rose-50"] = e => SetForeground(e, "#FFF1F2"),
            ["text-rose-100"] = e => SetForeground(e, "#FFE4E6"),
            ["text-rose-200"] = e => SetForeground(e, "#FECDD3"),
            ["text-rose-300"] = e => SetForeground(e, "#FDA4AF"),
            ["text-rose-400"] = e => SetForeground(e, "#FB7185"),
            ["text-rose-500"] = e => SetForeground(e, "#F43F5E"),
            ["text-rose-600"] = e => SetForeground(e, "#E11D48"),
            ["text-rose-700"] = e => SetForeground(e, "#BE123C"),
            ["text-rose-800"] = e => SetForeground(e, "#9F1239"),
            ["text-rose-900"] = e => SetForeground(e, "#881337"),

            // Slate Text
            ["text-slate-50"] = e => SetForeground(e, "#F8FAFC"),
            ["text-slate-100"] = e => SetForeground(e, "#F1F5F9"),
            ["text-slate-200"] = e => SetForeground(e, "#E2E8F0"),
            ["text-slate-300"] = e => SetForeground(e, "#CBD5E1"),
            ["text-slate-400"] = e => SetForeground(e, "#94A3B8"),
            ["text-slate-500"] = e => SetForeground(e, "#64748B"),
            ["text-slate-600"] = e => SetForeground(e, "#475569"),
            ["text-slate-700"] = e => SetForeground(e, "#334155"),
            ["text-slate-800"] = e => SetForeground(e, "#1E293B"),
            ["text-slate-900"] = e => SetForeground(e, "#0F172A"),

            // Sky Text
            ["text-sky-50"] = e => SetForeground(e, "#F0F9FF"),
            ["text-sky-100"] = e => SetForeground(e, "#E0F2FE"),
            ["text-sky-200"] = e => SetForeground(e, "#BAE6FD"),
            ["text-sky-300"] = e => SetForeground(e, "#7DD3FC"),
            ["text-sky-400"] = e => SetForeground(e, "#38BDF8"),
            ["text-sky-500"] = e => SetForeground(e, "#0EA5E9"),
            ["text-sky-600"] = e => SetForeground(e, "#0284C7"),
            ["text-sky-700"] = e => SetForeground(e, "#0369A1"),
            ["text-sky-800"] = e => SetForeground(e, "#075985"),
            ["text-sky-900"] = e => SetForeground(e, "#0C4A6E"),

            // Violet Text
            ["text-violet-50"] = e => SetForeground(e, "#F5F3FF"),
            ["text-violet-100"] = e => SetForeground(e, "#EDE9FE"),
            ["text-violet-200"] = e => SetForeground(e, "#DDD6FE"),
            ["text-violet-300"] = e => SetForeground(e, "#C4B5FD"),
            ["text-violet-400"] = e => SetForeground(e, "#A78BFA"),
            ["text-violet-500"] = e => SetForeground(e, "#8B5CF6"),
            ["text-violet-600"] = e => SetForeground(e, "#7C3AED"),
            ["text-violet-700"] = e => SetForeground(e, "#6D28D9"),
            ["text-violet-800"] = e => SetForeground(e, "#5B21B6"),
            ["text-violet-900"] = e => SetForeground(e, "#4C1D95"),

            // Fuchsia Text
            ["text-fuchsia-50"] = e => SetForeground(e, "#FDF4FF"),
            ["text-fuchsia-100"] = e => SetForeground(e, "#FAE8FF"),
            ["text-fuchsia-200"] = e => SetForeground(e, "#F5D0FE"),
            ["text-fuchsia-300"] = e => SetForeground(e, "#F0ABFC"),
            ["text-fuchsia-400"] = e => SetForeground(e, "#E879F9"),
            ["text-fuchsia-500"] = e => SetForeground(e, "#D946EF"),
            ["text-fuchsia-600"] = e => SetForeground(e, "#C026D3"),
            ["text-fuchsia-700"] = e => SetForeground(e, "#A21CAF"),
            ["text-fuchsia-800"] = e => SetForeground(e, "#86198F"),
            ["text-fuchsia-900"] = e => SetForeground(e, "#701A75"),

            // Amber Text
            ["text-amber-50"] = e => SetForeground(e, "#FFFBEB"),
            ["text-amber-100"] = e => SetForeground(e, "#FEF3C7"),
            ["text-amber-200"] = e => SetForeground(e, "#FDE68A"),
            ["text-amber-300"] = e => SetForeground(e, "#FCD34D"),
            ["text-amber-400"] = e => SetForeground(e, "#FBBF24"),
            ["text-amber-500"] = e => SetForeground(e, "#F59E0B"),
            ["text-amber-600"] = e => SetForeground(e, "#D97706"),
            ["text-amber-700"] = e => SetForeground(e, "#B45309"),
            ["text-amber-800"] = e => SetForeground(e, "#92400E"),
            ["text-amber-900"] = e => SetForeground(e, "#78350F"),

            // Zinc Text
            ["text-zinc-50"] = e => SetForeground(e, "#FAFAFA"),
            ["text-zinc-100"] = e => SetForeground(e, "#F4F4F5"),
            ["text-zinc-200"] = e => SetForeground(e, "#E4E4E7"),
            ["text-zinc-300"] = e => SetForeground(e, "#D4D4D8"),
            ["text-zinc-400"] = e => SetForeground(e, "#A1A1AA"),
            ["text-zinc-500"] = e => SetForeground(e, "#71717A"),
            ["text-zinc-600"] = e => SetForeground(e, "#52525B"),
            ["text-zinc-700"] = e => SetForeground(e, "#3F3F46"),
            ["text-zinc-800"] = e => SetForeground(e, "#27272A"),
            ["text-zinc-900"] = e => SetForeground(e, "#18181B"),

            // Neutral Text
            ["text-neutral-50"] = e => SetForeground(e, "#FAFAFA"),
            ["text-neutral-100"] = e => SetForeground(e, "#F5F5F5"),
            ["text-neutral-200"] = e => SetForeground(e, "#E5E5E5"),
            ["text-neutral-300"] = e => SetForeground(e, "#D4D4D4"),
            ["text-neutral-400"] = e => SetForeground(e, "#A3A3A3"),
            ["text-neutral-500"] = e => SetForeground(e, "#737373"),
            ["text-neutral-600"] = e => SetForeground(e, "#525252"),
            ["text-neutral-700"] = e => SetForeground(e, "#404040"),
            ["text-neutral-800"] = e => SetForeground(e, "#262626"),
            ["text-neutral-900"] = e => SetForeground(e, "#171717"),

            // Stone Text
            ["text-stone-50"] = e => SetForeground(e, "#FAFAF9"),
            ["text-stone-100"] = e => SetForeground(e, "#F5F5F4"),
            ["text-stone-200"] = e => SetForeground(e, "#E7E5E4"),
            ["text-stone-300"] = e => SetForeground(e, "#D6D3D1"),
            ["text-stone-400"] = e => SetForeground(e, "#A8A29E"),
            ["text-stone-500"] = e => SetForeground(e, "#78716C"),
            ["text-stone-600"] = e => SetForeground(e, "#57534E"),
            ["text-stone-700"] = e => SetForeground(e, "#44403C"),
            ["text-stone-800"] = e => SetForeground(e, "#292524"),
            ["text-stone-900"] = e => SetForeground(e, "#1C1917"),

            // Font Sizes
            ["text-xs"] = e => SetFontSize(e, 12),
            ["text-sm"] = e => SetFontSize(e, 14),
            ["text-base"] = e => SetFontSize(e, 16),
            ["text-lg"] = e => SetFontSize(e, 18),
            ["text-xl"] = e => SetFontSize(e, 20),
            ["text-2xl"] = e => SetFontSize(e, 24),
            ["text-3xl"] = e => SetFontSize(e, 30),
            ["text-4xl"] = e => SetFontSize(e, 36),
            ["text-5xl"] = e => SetFontSize(e, 48),
            ["text-6xl"] = e => SetFontSize(e, 60),
            ["text-7xl"] = e => SetFontSize(e, 72),
            ["text-8xl"] = e => SetFontSize(e, 96),
            ["text-9xl"] = e => SetFontSize(e, 128),

            // Font Weight
            ["font-thin"] = e => SetFontWeight(e, FontWeights.Thin),
            ["font-extralight"] = e => SetFontWeight(e, FontWeights.ExtraLight),
            ["font-light"] = e => SetFontWeight(e, FontWeights.Light),
            ["font-normal"] = e => SetFontWeight(e, FontWeights.Normal),
            ["font-medium"] = e => SetFontWeight(e, FontWeights.Medium),
            ["font-semibold"] = e => SetFontWeight(e, FontWeights.SemiBold),
            ["font-bold"] = e => SetFontWeight(e, FontWeights.Bold),
            ["font-extrabold"] = e => SetFontWeight(e, FontWeights.ExtraBold),
            ["font-black"] = e => SetFontWeight(e, FontWeights.Black),

            // Text Alignment
            ["text-left"] = e => SetTextAlignment(e, TextAlignment.Left),
            ["text-center"] = e => SetTextAlignment(e, TextAlignment.Center),
            ["text-right"] = e => SetTextAlignment(e, TextAlignment.Right),
            ["text-justify"] = e => SetTextAlignment(e, TextAlignment.Justify),
        };

        private static void SetForeground(DependencyObject element, string hex)
        {
            SetForeground(element, CreateBrush(hex));
        }

        private static void SetForeground(DependencyObject element, Brush brush)
        {
            switch (element)
            {
                case Control control:
                    control.Foreground = brush;
                    break;
                case TextBlock textBlock:
                    textBlock.Foreground = brush;
                    break;
            }
        }

        private static void SetFontSize(DependencyObject element, double size)
        {
            switch (element)
            {
                case Control control:
                    control.FontSize = size;
                    break;
                case TextBlock textBlock:
                    textBlock.FontSize = size;
                    break;
            }
        }

        private static void SetFontWeight(DependencyObject element, FontWeight weight)
        {
            switch (element)
            {
                case Control control:
                    control.FontWeight = weight;
                    break;
                case TextBlock textBlock:
                    textBlock.FontWeight = weight;
                    break;
            }
        }

        private static void SetTextAlignment(DependencyObject element, TextAlignment alignment)
        {
            if (element is TextBlock textBlock)
            {
                textBlock.TextAlignment = alignment;
            }
        }

        private static Brush CreateBrush(string hex)
        {
            return (Brush)new BrushConverter().ConvertFromString(hex)!;
        }
    }

}
