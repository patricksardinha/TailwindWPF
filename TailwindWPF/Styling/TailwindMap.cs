using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

using TailwindWPF.Styling.Styles;

namespace TailwindWPF.Styling
{
    public static class TailwindMap
    {
        public static readonly Dictionary<string, Action<DependencyObject>> ClassMap = new();

        private static readonly List<IStyleProvider> StyleProviders = new()
        {
            new BackgroundStyles(),
            new TextStyles(),
            new SpacingStyles(),
            new BorderStyles(),
            new LayoutStyles(),
            new ButtonStyles(),
            new AnimationStyles(),
            new HoverStyles(),
            new GridStyles(),
            new FlexboxStyles(),
            new DisplayPositionStyles(),
            new EffectsStyles(),
            new TransformStyles(),
        };

        static TailwindMap()
        {
            foreach (var provider in StyleProviders)
            {
                foreach (var style in provider.GetStyles())
                {
                    ClassMap[style.Key] = style.Value;
                }
            }
        }

        public static void RegisterCustomStyles(Dictionary<string, Action<DependencyObject>> customStyles)
        {
            foreach (var style in customStyles)
            {
                ClassMap[style.Key] = style.Value;
            }
        }

        public static void RegisterStyleProvider(IStyleProvider provider)
        {
            foreach (var style in provider.GetStyles())
            {
                ClassMap[style.Key] = style.Value;
            }
        }
    }
}
