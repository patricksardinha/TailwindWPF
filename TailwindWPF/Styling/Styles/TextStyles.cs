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
        public override Dictionary<string, Action<Control>> GetStyles() => new()
        {
            // Text Colors
            ["text-gray-50"] = c => c.Foreground = CreateBrush("#F9FAFB"),
            ["text-gray-100"] = c => c.Foreground = CreateBrush("#F3F4F6"),
            ["text-gray-200"] = c => c.Foreground = CreateBrush("#E5E7EB"),
            ["text-gray-300"] = c => c.Foreground = CreateBrush("#D1D5DB"),
            ["text-gray-400"] = c => c.Foreground = CreateBrush("#9CA3AF"),
            ["text-gray-500"] = c => c.Foreground = CreateBrush("#6B7280"),
            ["text-gray-600"] = c => c.Foreground = CreateBrush("#4B5563"),
            ["text-gray-700"] = c => c.Foreground = CreateBrush("#374151"),
            ["text-gray-800"] = c => c.Foreground = CreateBrush("#1F2937"),
            ["text-gray-900"] = c => c.Foreground = CreateBrush("#111827"),
            ["text-white"] = c => c.Foreground = Brushes.White,
            ["text-black"] = c => c.Foreground = Brushes.Black,

            // Font Sizes (basé sur rem -> px conversion)
            ["text-xs"] = c => c.FontSize = 12,
            ["text-sm"] = c => c.FontSize = 14,
            ["text-base"] = c => c.FontSize = 16,
            ["text-lg"] = c => c.FontSize = 18,
            ["text-xl"] = c => c.FontSize = 20,
            ["text-2xl"] = c => c.FontSize = 24,
            ["text-3xl"] = c => c.FontSize = 30,
            ["text-4xl"] = c => c.FontSize = 36,
            ["text-5xl"] = c => c.FontSize = 48,
            ["text-6xl"] = c => c.FontSize = 60,
            ["text-7xl"] = c => c.FontSize = 72,
            ["text-8xl"] = c => c.FontSize = 96,
            ["text-9xl"] = c => c.FontSize = 128,

            // Font Weight
            ["font-thin"] = c => c.FontWeight = FontWeights.Thin,
            ["font-extralight"] = c => c.FontWeight = FontWeights.ExtraLight,
            ["font-light"] = c => c.FontWeight = FontWeights.Light,
            ["font-normal"] = c => c.FontWeight = FontWeights.Normal,
            ["font-medium"] = c => c.FontWeight = FontWeights.Medium,
            ["font-semibold"] = c => c.FontWeight = FontWeights.SemiBold,
            ["font-bold"] = c => c.FontWeight = FontWeights.Bold,
            ["font-extrabold"] = c => c.FontWeight = FontWeights.ExtraBold,
            ["font-black"] = c => c.FontWeight = FontWeights.Black,

            // Text Alignment (pour TextBlock, Label, etc.)

            ["text-left"] = e => SetTextAlignment(e, TextAlignment.Left),
            ["text-center"] = e => SetTextAlignment(e, TextAlignment.Center),
            ["text-right"] = e => SetTextAlignment(e, TextAlignment.Right),
            ["text-justify"] = e => SetTextAlignment(e, TextAlignment.Justify),

        };

        private static void SetForeground(FrameworkElement element, string hex)
        {
            SetForeground(element, CreateBrush(hex));
        }

        private static void SetForeground(FrameworkElement element, Brush brush)
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

        private static void SetFontSize(FrameworkElement element, double size)
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

        private static void SetFontWeight(FrameworkElement element, FontWeight weight)
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

        private static void SetTextAlignment(FrameworkElement element, TextAlignment alignment)
        {
            if (element is TextBlock textBlock)
            {
                textBlock.TextAlignment = alignment;
            }
        }
    }
}
