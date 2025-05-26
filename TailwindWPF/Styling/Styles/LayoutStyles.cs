using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TailwindWPF.Styling.Styles
{
    public class LayoutStyles : BaseStyleProvider
    {
        public override Dictionary<string, Action<Control>> GetStyles() => new()
        {
            // Width
            ["w-0"] = c => c.Width = 0,
            ["w-px"] = c => c.Width = 1,
            ["w-0.5"] = c => c.Width = 2,
            ["w-1"] = c => c.Width = 4,
            ["w-1.5"] = c => c.Width = 6,
            ["w-2"] = c => c.Width = 8,
            ["w-2.5"] = c => c.Width = 10,
            ["w-3"] = c => c.Width = 12,
            ["w-3.5"] = c => c.Width = 14,
            ["w-4"] = c => c.Width = 16,
            ["w-5"] = c => c.Width = 20,
            ["w-6"] = c => c.Width = 24,
            ["w-7"] = c => c.Width = 28,
            ["w-8"] = c => c.Width = 32,
            ["w-9"] = c => c.Width = 36,
            ["w-10"] = c => c.Width = 40,
            ["w-11"] = c => c.Width = 44,
            ["w-12"] = c => c.Width = 48,
            ["w-14"] = c => c.Width = 56,
            ["w-16"] = c => c.Width = 64,
            ["w-20"] = c => c.Width = 80,
            ["w-24"] = c => c.Width = 96,
            ["w-28"] = c => c.Width = 112,
            ["w-32"] = c => c.Width = 128,
            ["w-36"] = c => c.Width = 144,
            ["w-40"] = c => c.Width = 160,
            ["w-44"] = c => c.Width = 176,
            ["w-48"] = c => c.Width = 192,
            ["w-52"] = c => c.Width = 208,
            ["w-56"] = c => c.Width = 224,
            ["w-60"] = c => c.Width = 240,
            ["w-64"] = c => c.Width = 256,
            ["w-72"] = c => c.Width = 288,
            ["w-80"] = c => c.Width = 320,
            ["w-96"] = c => c.Width = 384,
            ["w-auto"] = c => c.Width = double.NaN,
            ["w-full"] = c => c.Width = double.NaN, // -> parent

            // Height
            ["h-0"] = c => c.Height = 0,
            ["h-px"] = c => c.Height = 1,
            ["h-0.5"] = c => c.Height = 2,
            ["h-1"] = c => c.Height = 4,
            ["h-1.5"] = c => c.Height = 6,
            ["h-2"] = c => c.Height = 8,
            ["h-2.5"] = c => c.Height = 10,
            ["h-3"] = c => c.Height = 12,
            ["h-3.5"] = c => c.Height = 14,
            ["h-4"] = c => c.Height = 16,
            ["h-5"] = c => c.Height = 20,
            ["h-6"] = c => c.Height = 24,
            ["h-8"] = c => c.Height = 32,
            ["h-10"] = c => c.Height = 40,
            ["h-12"] = c => c.Height = 48,
            ["h-16"] = c => c.Height = 64,
            ["h-20"] = c => c.Height = 80,
            ["h-24"] = c => c.Height = 96,
            ["h-32"] = c => c.Height = 128,
            ["h-40"] = c => c.Height = 160,
            ["h-48"] = c => c.Height = 192,
            ["h-56"] = c => c.Height = 224,
            ["h-64"] = c => c.Height = 256,
            ["h-auto"] = c => c.Height = double.NaN,
            ["h-full"] = c => c.Height = double.NaN, // -> parent

            // Min/Max Width
            ["min-w-0"] = c => c.MinWidth = 0,
            ["min-w-full"] = c => c.MinWidth = double.PositiveInfinity,
            ["max-w-none"] = c => c.MaxWidth = double.PositiveInfinity,
            ["max-w-xs"] = c => c.MaxWidth = 320,
            ["max-w-sm"] = c => c.MaxWidth = 384,
            ["max-w-md"] = c => c.MaxWidth = 448,
            ["max-w-lg"] = c => c.MaxWidth = 512,
            ["max-w-xl"] = c => c.MaxWidth = 576,
            ["max-w-2xl"] = c => c.MaxWidth = 672,
            ["max-w-3xl"] = c => c.MaxWidth = 768,
            ["max-w-4xl"] = c => c.MaxWidth = 896,
            ["max-w-5xl"] = c => c.MaxWidth = 1024,
            ["max-w-6xl"] = c => c.MaxWidth = 1152,
            ["max-w-7xl"] = c => c.MaxWidth = 1280,
            ["max-w-full"] = c => c.MaxWidth = double.PositiveInfinity,
        };
    }
}