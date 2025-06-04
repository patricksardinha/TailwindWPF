using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace TailwindWPF.Styling.Styles
{
    public class EffectsStyles : BaseStyleProvider
    {
        public override Dictionary<string, Action<DependencyObject>> GetStyles() => new()
        {
            // Opacity
            ["opacity-0"] = d => SetOpacity(d, 0),
            ["opacity-5"] = d => SetOpacity(d, 0.05),
            ["opacity-10"] = d => SetOpacity(d, 0.1),
            ["opacity-20"] = d => SetOpacity(d, 0.2),
            ["opacity-25"] = d => SetOpacity(d, 0.25),
            ["opacity-30"] = d => SetOpacity(d, 0.3),
            ["opacity-40"] = d => SetOpacity(d, 0.4),
            ["opacity-50"] = d => SetOpacity(d, 0.5),
            ["opacity-60"] = d => SetOpacity(d, 0.6),
            ["opacity-70"] = d => SetOpacity(d, 0.7),
            ["opacity-75"] = d => SetOpacity(d, 0.75),
            ["opacity-80"] = d => SetOpacity(d, 0.8),
            ["opacity-90"] = d => SetOpacity(d, 0.9),
            ["opacity-95"] = d => SetOpacity(d, 0.95),
            ["opacity-100"] = d => SetOpacity(d, 1.0),

            // Box Shadow
            ["shadow-sm"] = d => SetBoxShadow(d, 1, 1, 3, 0, Colors.Black, 0.1),
            ["shadow"] = d => SetBoxShadow(d, 1, 1, 3, 0, Colors.Black, 0.1),
            ["shadow-md"] = d => SetBoxShadow(d, 4, 4, 6, -1, Colors.Black, 0.1),
            ["shadow-lg"] = d => SetBoxShadow(d, 10, 10, 15, -3, Colors.Black, 0.1),
            ["shadow-xl"] = d => SetBoxShadow(d, 20, 20, 25, -5, Colors.Black, 0.1),
            ["shadow-2xl"] = d => SetBoxShadow(d, 25, 25, 50, -12, Colors.Black, 0.25),
            ["shadow-inner"] = d => SetInnerShadow(d),
            ["shadow-none"] = d => RemoveShadow(d),

            // Colored Shadows
            ["shadow-gray-500"] = d => SetBoxShadow(d, 4, 4, 6, -1, (Color)ColorConverter.ConvertFromString("#6B7280"), 0.4),
            ["shadow-red-500"] = d => SetBoxShadow(d, 4, 4, 6, -1, (Color)ColorConverter.ConvertFromString("#EF4444"), 0.4),
            ["shadow-blue-500"] = d => SetBoxShadow(d, 4, 4, 6, -1, (Color)ColorConverter.ConvertFromString("#3B82F6"), 0.4),
            ["shadow-green-500"] = d => SetBoxShadow(d, 4, 4, 6, -1, (Color)ColorConverter.ConvertFromString("#22C55E"), 0.4),
            ["shadow-yellow-500"] = d => SetBoxShadow(d, 4, 4, 6, -1, (Color)ColorConverter.ConvertFromString("#EAB308"), 0.4),
            ["shadow-purple-500"] = d => SetBoxShadow(d, 4, 4, 6, -1, (Color)ColorConverter.ConvertFromString("#A855F7"), 0.4),
            ["shadow-pink-500"] = d => SetBoxShadow(d, 4, 4, 6, -1, (Color)ColorConverter.ConvertFromString("#EC4899"), 0.4),

            // Drop Shadow
            ["drop-shadow-sm"] = d => SetDropShadow(d, 1, 1, 2, Colors.Black, 0.05),
            ["drop-shadow"] = d => SetDropShadow(d, 1, 1, 2, Colors.Black, 0.1),
            ["drop-shadow-md"] = d => SetDropShadow(d, 4, 4, 6, Colors.Black, 0.07),
            ["drop-shadow-lg"] = d => SetDropShadow(d, 10, 10, 8, Colors.Black, 0.04),
            ["drop-shadow-xl"] = d => SetDropShadow(d, 20, 20, 13, Colors.Black, 0.03),
            ["drop-shadow-2xl"] = d => SetDropShadow(d, 25, 25, 25, Colors.Black, 0.15),
            ["drop-shadow-none"] = d => RemoveDropShadow(d),

            // Blur Effect
            ["blur-none"] = d => RemoveBlur(d),
            ["blur-sm"] = d => SetBlur(d, 4),
            ["blur"] = d => SetBlur(d, 8),
            ["blur-md"] = d => SetBlur(d, 12),
            ["blur-lg"] = d => SetBlur(d, 16),
            ["blur-xl"] = d => SetBlur(d, 24),
            ["blur-2xl"] = d => SetBlur(d, 40),
            ["blur-3xl"] = d => SetBlur(d, 64),

            // Brightness
            ["brightness-0"] = d => SetBrightness(d, 0),
            ["brightness-50"] = d => SetBrightness(d, 0.5),
            ["brightness-75"] = d => SetBrightness(d, 0.75),
            ["brightness-90"] = d => SetBrightness(d, 0.9),
            ["brightness-95"] = d => SetBrightness(d, 0.95),
            ["brightness-100"] = d => SetBrightness(d, 1.0),
            ["brightness-105"] = d => SetBrightness(d, 1.05),
            ["brightness-110"] = d => SetBrightness(d, 1.1),
            ["brightness-125"] = d => SetBrightness(d, 1.25),
            ["brightness-150"] = d => SetBrightness(d, 1.5),
            ["brightness-200"] = d => SetBrightness(d, 2.0),

            // Contrast
            ["contrast-0"] = d => SetContrast(d, 0),
            ["contrast-50"] = d => SetContrast(d, 0.5),
            ["contrast-75"] = d => SetContrast(d, 0.75),
            ["contrast-100"] = d => SetContrast(d, 1.0),
            ["contrast-125"] = d => SetContrast(d, 1.25),
            ["contrast-150"] = d => SetContrast(d, 1.5),
            ["contrast-200"] = d => SetContrast(d, 2.0),

            // Grayscale
            ["grayscale-0"] = d => SetGrayscale(d, 0),
            ["grayscale"] = d => SetGrayscale(d, 1.0),

            // Sepia
            ["sepia-0"] = d => SetSepia(d, 0),
            ["sepia"] = d => SetSepia(d, 1.0),
        };

        private static void SetOpacity(DependencyObject d, double opacity)
        {
            if (d is UIElement element)
            {
                element.Opacity = opacity;
            }
        }

        private static void SetBoxShadow(DependencyObject d, double offsetX, double offsetY, double blurRadius, double spreadRadius, Color color, double opacity)
        {
            if (d is UIElement element)
            {
                var shadowColor = Color.FromArgb((byte)(255 * opacity), color.R, color.G, color.B);

                var dropShadow = new DropShadowEffect
                {
                    Color = shadowColor,
                    Direction = 315, // standard
                    ShadowDepth = Math.Sqrt(offsetX * offsetX + offsetY * offsetY),
                    BlurRadius = blurRadius,
                    Opacity = opacity
                };

                element.Effect = dropShadow;
            }
        }

        private static void SetInnerShadow(DependencyObject d)
        {
            if (d is UIElement element)
            {
                // Simulate internal border
                var dropShadow = new DropShadowEffect
                {
                    Color = Colors.Black,
                    Direction = 135, // 315-180
                    ShadowDepth = 2,
                    BlurRadius = 4,
                    Opacity = 0.3
                };

                element.Effect = dropShadow;
            }
        }

        private static void SetDropShadow(DependencyObject d, double offsetX, double offsetY, double blurRadius, Color color, double opacity)
        {
            if (d is UIElement element)
            {
                var shadowColor = Color.FromArgb((byte)(255 * opacity), color.R, color.G, color.B);

                var dropShadow = new DropShadowEffect
                {
                    Color = shadowColor,
                    Direction = 315,
                    ShadowDepth = Math.Sqrt(offsetX * offsetX + offsetY * offsetY),
                    BlurRadius = blurRadius,
                    Opacity = opacity
                };

                element.Effect = dropShadow;
            }
        }

        private static void RemoveShadow(DependencyObject d)
        {
            if (d is UIElement element)
            {
                element.Effect = null;
            }
        }

        private static void RemoveDropShadow(DependencyObject d)
        {
            RemoveShadow(d);
        }

        private static void SetBlur(DependencyObject d, double radius)
        {
            if (d is UIElement element)
            {
                var blurEffect = new BlurEffect
                {
                    Radius = radius
                };

                element.Effect = blurEffect;
            }
        }

        private static void RemoveBlur(DependencyObject d)
        {
            if (d is UIElement element)
            {
                element.Effect = null;
            }
        }

        private static void SetBrightness(DependencyObject d, double brightness)
        {
            if (d is UIElement element)
            {
                if (brightness < 1.0)
                {
                    element.Opacity = brightness;
                }
                else
                {
                    element.Opacity = 1.0;
                }
            }
        }

        private static void SetContrast(DependencyObject d, double contrast)
        {
            if (d is UIElement element)
            {
                // Tofix. Approx?
                element.SetValue(UIElement.OpacityProperty, Math.Min(contrast, 1.0));
            }
        }

        private static void SetGrayscale(DependencyObject d, double amount)
        {
            if (d is UIElement element && amount > 0)
            {
                // Tofix: custom effect for grayscale
                //var colorMatrix = new System.Windows.Media.Effects.ColorMatrixEffect();

                // Approx.
                element.Opacity = 1.0 - (amount * 0.3);
            }
        }

        private static void SetSepia(DependencyObject d, double amount)
        {
            if (d is UIElement element && amount > 0)
            {
                // Approx.
                element.Opacity = 1.0 - (amount * 0.1);
            }
        }
    }
}