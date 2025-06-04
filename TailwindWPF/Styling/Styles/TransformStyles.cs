using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace TailwindWPF.Styling.Styles
{
    public class TransformStyles : BaseStyleProvider
    {
        public override Dictionary<string, Action<DependencyObject>> GetStyles() => new()
        {
            // Scale
            ["scale-0"] = d => SetScale(d, 0, 0),
            ["scale-50"] = d => SetScale(d, 0.5, 0.5),
            ["scale-75"] = d => SetScale(d, 0.75, 0.75),
            ["scale-90"] = d => SetScale(d, 0.9, 0.9),
            ["scale-95"] = d => SetScale(d, 0.95, 0.95),
            ["scale-100"] = d => SetScale(d, 1.0, 1.0),
            ["scale-105"] = d => SetScale(d, 1.05, 1.05),
            ["scale-110"] = d => SetScale(d, 1.1, 1.1),
            ["scale-125"] = d => SetScale(d, 1.25, 1.25),
            ["scale-150"] = d => SetScale(d, 1.5, 1.5),

            // Scale X
            ["scale-x-0"] = d => SetScaleX(d, 0),
            ["scale-x-50"] = d => SetScaleX(d, 0.5),
            ["scale-x-75"] = d => SetScaleX(d, 0.75),
            ["scale-x-90"] = d => SetScaleX(d, 0.9),
            ["scale-x-95"] = d => SetScaleX(d, 0.95),
            ["scale-x-100"] = d => SetScaleX(d, 1.0),
            ["scale-x-105"] = d => SetScaleX(d, 1.05),
            ["scale-x-110"] = d => SetScaleX(d, 1.1),
            ["scale-x-125"] = d => SetScaleX(d, 1.25),
            ["scale-x-150"] = d => SetScaleX(d, 1.5),

            // Scale Y
            ["scale-y-0"] = d => SetScaleY(d, 0),
            ["scale-y-50"] = d => SetScaleY(d, 0.5),
            ["scale-y-75"] = d => SetScaleY(d, 0.75),
            ["scale-y-90"] = d => SetScaleY(d, 0.9),
            ["scale-y-95"] = d => SetScaleY(d, 0.95),
            ["scale-y-100"] = d => SetScaleY(d, 1.0),
            ["scale-y-105"] = d => SetScaleY(d, 1.05),
            ["scale-y-110"] = d => SetScaleY(d, 1.1),
            ["scale-y-125"] = d => SetScaleY(d, 1.25),
            ["scale-y-150"] = d => SetScaleY(d, 1.5),

            // Rotate
            ["rotate-0"] = d => SetRotate(d, 0),
            ["rotate-1"] = d => SetRotate(d, 1),
            ["rotate-2"] = d => SetRotate(d, 2),
            ["rotate-3"] = d => SetRotate(d, 3),
            ["rotate-6"] = d => SetRotate(d, 6),
            ["rotate-12"] = d => SetRotate(d, 12),
            ["rotate-45"] = d => SetRotate(d, 45),
            ["rotate-90"] = d => SetRotate(d, 90),
            ["rotate-180"] = d => SetRotate(d, 180),
            ["-rotate-1"] = d => SetRotate(d, -1),
            ["-rotate-2"] = d => SetRotate(d, -2),
            ["-rotate-3"] = d => SetRotate(d, -3),
            ["-rotate-6"] = d => SetRotate(d, -6),
            ["-rotate-12"] = d => SetRotate(d, -12),
            ["-rotate-45"] = d => SetRotate(d, -45),
            ["-rotate-90"] = d => SetRotate(d, -90),
            ["-rotate-180"] = d => SetRotate(d, -180),

            // Translate X
            ["translate-x-0"] = d => SetTranslateX(d, 0),
            ["translate-x-px"] = d => SetTranslateX(d, 1),
            ["translate-x-0.5"] = d => SetTranslateX(d, 2),
            ["translate-x-1"] = d => SetTranslateX(d, 4),
            ["translate-x-1.5"] = d => SetTranslateX(d, 6),
            ["translate-x-2"] = d => SetTranslateX(d, 8),
            ["translate-x-2.5"] = d => SetTranslateX(d, 10),
            ["translate-x-3"] = d => SetTranslateX(d, 12),
            ["translate-x-3.5"] = d => SetTranslateX(d, 14),
            ["translate-x-4"] = d => SetTranslateX(d, 16),
            ["translate-x-5"] = d => SetTranslateX(d, 20),
            ["translate-x-6"] = d => SetTranslateX(d, 24),
            ["translate-x-8"] = d => SetTranslateX(d, 32),
            ["translate-x-10"] = d => SetTranslateX(d, 40),
            ["translate-x-12"] = d => SetTranslateX(d, 48),
            ["translate-x-16"] = d => SetTranslateX(d, 64),
            ["translate-x-20"] = d => SetTranslateX(d, 80),
            ["translate-x-24"] = d => SetTranslateX(d, 96),
            ["translate-x-32"] = d => SetTranslateX(d, 128),
            ["-translate-x-1"] = d => SetTranslateX(d, -4),
            ["-translate-x-2"] = d => SetTranslateX(d, -8),
            ["-translate-x-4"] = d => SetTranslateX(d, -16),
            ["-translate-x-8"] = d => SetTranslateX(d, -32),
            ["-translate-x-16"] = d => SetTranslateX(d, -64),
            ["-translate-x-32"] = d => SetTranslateX(d, -128),

            // Translate Y
            ["translate-y-0"] = d => SetTranslateY(d, 0),
            ["translate-y-px"] = d => SetTranslateY(d, 1),
            ["translate-y-0.5"] = d => SetTranslateY(d, 2),
            ["translate-y-1"] = d => SetTranslateY(d, 4),
            ["translate-y-1.5"] = d => SetTranslateY(d, 6),
            ["translate-y-2"] = d => SetTranslateY(d, 8),
            ["translate-y-2.5"] = d => SetTranslateY(d, 10),
            ["translate-y-3"] = d => SetTranslateY(d, 12),
            ["translate-y-3.5"] = d => SetTranslateY(d, 14),
            ["translate-y-4"] = d => SetTranslateY(d, 16),
            ["translate-y-5"] = d => SetTranslateY(d, 20),
            ["translate-y-6"] = d => SetTranslateY(d, 24),
            ["translate-y-8"] = d => SetTranslateY(d, 32),
            ["translate-y-10"] = d => SetTranslateY(d, 40),
            ["translate-y-12"] = d => SetTranslateY(d, 48),
            ["translate-y-16"] = d => SetTranslateY(d, 64),
            ["translate-y-20"] = d => SetTranslateY(d, 80),
            ["translate-y-24"] = d => SetTranslateY(d, 96),
            ["translate-y-32"] = d => SetTranslateY(d, 128),
            ["-translate-y-1"] = d => SetTranslateY(d, -4),
            ["-translate-y-2"] = d => SetTranslateY(d, -8),
            ["-translate-y-4"] = d => SetTranslateY(d, -16),
            ["-translate-y-8"] = d => SetTranslateY(d, -32),
            ["-translate-y-16"] = d => SetTranslateY(d, -64),
            ["-translate-y-32"] = d => SetTranslateY(d, -128),

            // Skew X
            ["skew-x-0"] = d => SetSkewX(d, 0),
            ["skew-x-1"] = d => SetSkewX(d, 1),
            ["skew-x-2"] = d => SetSkewX(d, 2),
            ["skew-x-3"] = d => SetSkewX(d, 3),
            ["skew-x-6"] = d => SetSkewX(d, 6),
            ["skew-x-12"] = d => SetSkewX(d, 12),
            ["-skew-x-1"] = d => SetSkewX(d, -1),
            ["-skew-x-2"] = d => SetSkewX(d, -2),
            ["-skew-x-3"] = d => SetSkewX(d, -3),
            ["-skew-x-6"] = d => SetSkewX(d, -6),
            ["-skew-x-12"] = d => SetSkewX(d, -12),

            // Skew Y
            ["skew-y-0"] = d => SetSkewY(d, 0),
            ["skew-y-1"] = d => SetSkewY(d, 1),
            ["skew-y-2"] = d => SetSkewY(d, 2),
            ["skew-y-3"] = d => SetSkewY(d, 3),
            ["skew-y-6"] = d => SetSkewY(d, 6),
            ["skew-y-12"] = d => SetSkewY(d, 12),
            ["-skew-y-1"] = d => SetSkewY(d, -1),
            ["-skew-y-2"] = d => SetSkewY(d, -2),
            ["-skew-y-3"] = d => SetSkewY(d, -3),
            ["-skew-y-6"] = d => SetSkewY(d, -6),
            ["-skew-y-12"] = d => SetSkewY(d, -12),

            // Transform Origin
            ["origin-center"] = d => SetTransformOrigin(d, 0.5, 0.5),
            ["origin-top"] = d => SetTransformOrigin(d, 0.5, 0),
            ["origin-top-right"] = d => SetTransformOrigin(d, 1, 0),
            ["origin-right"] = d => SetTransformOrigin(d, 1, 0.5),
            ["origin-bottom-right"] = d => SetTransformOrigin(d, 1, 1),
            ["origin-bottom"] = d => SetTransformOrigin(d, 0.5, 1),
            ["origin-bottom-left"] = d => SetTransformOrigin(d, 0, 1),
            ["origin-left"] = d => SetTransformOrigin(d, 0, 0.5),
            ["origin-top-left"] = d => SetTransformOrigin(d, 0, 0),
        };

        private static void SetScale(DependencyObject d, double scaleX, double scaleY)
        {
            if (d is UIElement element)
            {
                var transform = GetOrCreateTransformGroup(element);
                var scaleTransform = GetOrCreateTransform<ScaleTransform>(transform);
                scaleTransform.ScaleX = scaleX;
                scaleTransform.ScaleY = scaleY;
            }
        }

        private static void SetScaleX(DependencyObject d, double scaleX)
        {
            if (d is UIElement element)
            {
                var transform = GetOrCreateTransformGroup(element);
                var scaleTransform = GetOrCreateTransform<ScaleTransform>(transform);
                scaleTransform.ScaleX = scaleX;
            }
        }

        private static void SetScaleY(DependencyObject d, double scaleY)
        {
            if (d is UIElement element)
            {
                var transform = GetOrCreateTransformGroup(element);
                var scaleTransform = GetOrCreateTransform<ScaleTransform>(transform);
                scaleTransform.ScaleY = scaleY;
            }
        }

        private static void SetRotate(DependencyObject d, double angle)
        {
            if (d is UIElement element)
            {
                var transform = GetOrCreateTransformGroup(element);
                var rotateTransform = GetOrCreateTransform<RotateTransform>(transform);
                rotateTransform.Angle = angle;
            }
        }

        private static void SetTranslateX(DependencyObject d, double translateX)
        {
            if (d is UIElement element)
            {
                var transform = GetOrCreateTransformGroup(element);
                var translateTransform = GetOrCreateTransform<TranslateTransform>(transform);
                translateTransform.X = translateX;
            }
        }

        private static void SetTranslateY(DependencyObject d, double translateY)
        {
            if (d is UIElement element)
            {
                var transform = GetOrCreateTransformGroup(element);
                var translateTransform = GetOrCreateTransform<TranslateTransform>(transform);
                translateTransform.Y = translateY;
            }
        }

        private static void SetSkewX(DependencyObject d, double skewX)
        {
            if (d is UIElement element)
            {
                var transform = GetOrCreateTransformGroup(element);
                var skewTransform = GetOrCreateTransform<SkewTransform>(transform);
                skewTransform.AngleX = skewX;
            }
        }

        private static void SetSkewY(DependencyObject d, double skewY)
        {
            if (d is UIElement element)
            {
                var transform = GetOrCreateTransformGroup(element);
                var skewTransform = GetOrCreateTransform<SkewTransform>(transform);
                skewTransform.AngleY = skewY;
            }
        }

        private static void SetTransformOrigin(DependencyObject d, double x, double y)
        {
            if (d is UIElement element)
            {
                element.RenderTransformOrigin = new Point(x, y);
            }
        }

        private static TransformGroup GetOrCreateTransformGroup(UIElement element)
        {
            if (element.RenderTransform is not TransformGroup group)
            {
                group = new TransformGroup();
                element.RenderTransform = group;
            }
            return group;
        }

        private static T GetOrCreateTransform<T>(TransformGroup group) where T : Transform, new()
        {
            foreach (var transform in group.Children)
            {
                if (transform is T existing)
                    return existing;
            }

            var newTransform = new T();
            group.Children.Add(newTransform);
            return newTransform;
        }
    }
}