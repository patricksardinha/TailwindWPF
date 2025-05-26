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
            ["text-white"] = e => SetForeground(e, Brushes.White),
            ["text-black"] = e => SetForeground(e, Brushes.Black),

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
