using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TailwindWPF.Styling.Styles
{
    public class LayoutStyles : BaseStyleProvider
    {
        public override Dictionary<string, Action<DependencyObject>> GetStyles() => new()
        {
            // Width
            ["w-0"] = SetWidth(0),
            ["w-px"] = SetWidth(1),
            ["w-0.5"] = SetWidth(2),
            ["w-1"] = SetWidth(4),
            ["w-1.5"] = SetWidth(6),
            ["w-2"] = SetWidth(8),
            ["w-2.5"] = SetWidth(10),
            ["w-3"] = SetWidth(12),
            ["w-3.5"] = SetWidth(14),
            ["w-4"] = SetWidth(16),
            ["w-5"] = SetWidth(20),
            ["w-6"] = SetWidth(24),
            ["w-7"] = SetWidth(28),
            ["w-8"] = SetWidth(32),
            ["w-9"] = SetWidth(36),
            ["w-10"] = SetWidth(40),
            ["w-11"] = SetWidth(44),
            ["w-12"] = SetWidth(48),
            ["w-14"] = SetWidth(56),
            ["w-16"] = SetWidth(64),
            ["w-20"] = SetWidth(80),
            ["w-24"] = SetWidth(96),
            ["w-28"] = SetWidth(112),
            ["w-32"] = SetWidth(128),
            ["w-36"] = SetWidth(144),
            ["w-40"] = SetWidth(160),
            ["w-44"] = SetWidth(176),
            ["w-48"] = SetWidth(192),
            ["w-52"] = SetWidth(208),
            ["w-56"] = SetWidth(224),
            ["w-60"] = SetWidth(240),
            ["w-64"] = SetWidth(256),
            ["w-72"] = SetWidth(288),
            ["w-80"] = SetWidth(320),
            ["w-96"] = SetWidth(384),
            ["w-auto"] = SetWidth(double.NaN),
            ["w-full"] = SetWidth(double.NaN),

            // Height
            ["h-0"] = SetHeight(0),
            ["h-px"] = SetHeight(1),
            ["h-0.5"] = SetHeight(2),
            ["h-1"] = SetHeight(4),
            ["h-1.5"] = SetHeight(6),
            ["h-2"] = SetHeight(8),
            ["h-2.5"] = SetHeight(10),
            ["h-3"] = SetHeight(12),
            ["h-3.5"] = SetHeight(14),
            ["h-4"] = SetHeight(16),
            ["h-5"] = SetHeight(20),
            ["h-6"] = SetHeight(24),
            ["h-8"] = SetHeight(32),
            ["h-10"] = SetHeight(40),
            ["h-12"] = SetHeight(48),
            ["h-16"] = SetHeight(64),
            ["h-20"] = SetHeight(80),
            ["h-24"] = SetHeight(96),
            ["h-32"] = SetHeight(128),
            ["h-40"] = SetHeight(160),
            ["h-48"] = SetHeight(192),
            ["h-56"] = SetHeight(224),
            ["h-64"] = SetHeight(256),
            ["h-auto"] = SetHeight(double.NaN),
            ["h-full"] = SetHeight(double.NaN),

            // Min Width
            ["min-w-0"] = SetMinWidth(0),
            ["min-w-full"] = SetMinWidth(double.PositiveInfinity),

            // Max Width
            ["max-w-none"] = SetMaxWidth(double.PositiveInfinity),
            ["max-w-xs"] = SetMaxWidth(320),
            ["max-w-sm"] = SetMaxWidth(384),
            ["max-w-md"] = SetMaxWidth(448),
            ["max-w-lg"] = SetMaxWidth(512),
            ["max-w-xl"] = SetMaxWidth(576),
            ["max-w-2xl"] = SetMaxWidth(672),
            ["max-w-3xl"] = SetMaxWidth(768),
            ["max-w-4xl"] = SetMaxWidth(896),
            ["max-w-5xl"] = SetMaxWidth(1024),
            ["max-w-6xl"] = SetMaxWidth(1152),
            ["max-w-7xl"] = SetMaxWidth(1280),
            ["max-w-full"] = SetMaxWidth(double.PositiveInfinity),
        };

        private static Action<DependencyObject> SetWidth(double value) => d =>
        {
            if (d is FrameworkElement fe) fe.Width = value;
        };

        private static Action<DependencyObject> SetHeight(double value) => d =>
        {
            if (d is FrameworkElement fe) fe.Height = value;
        };

        private static Action<DependencyObject> SetMinWidth(double value) => d =>
        {
            if (d is FrameworkElement fe) fe.MinWidth = value;
        };

        private static Action<DependencyObject> SetMaxWidth(double value) => d =>
        {
            if (d is FrameworkElement fe) fe.MaxWidth = value;
        };
    }

}