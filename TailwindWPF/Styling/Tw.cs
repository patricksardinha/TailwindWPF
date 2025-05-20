using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

using TailwindWPF.Controls;

namespace TailwindWPF.Styling
{
    public static class Tw
    {
        public static readonly DependencyProperty ClassProperty =
            DependencyProperty.RegisterAttached(
                "Class",
                typeof(string),
                typeof(Tw),
                new PropertyMetadata(null, OnClassChanged));

        public static void SetClass(DependencyObject element, string value) =>
            element.SetValue(ClassProperty, value);

        public static string GetClass(DependencyObject element) =>
            (string)element.GetValue(ClassProperty);

        private static void OnClassChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not Control ctrl || e.NewValue is not string classString)
                return;

            var classes = classString.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var cls in classes)
            {
                switch (cls)
                {
                    case "bg-blue-500":
                        ctrl.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3B82F6"));
                        break;
                    case "text-white":
                        ctrl.Foreground = Brushes.White;
                        break;
                    case "text-lg":
                        ctrl.FontSize = 18;
                        break;
                    case "p-3":
                        ctrl.Padding = new Thickness(12);
                        break;
                    case "rounded":
                        if (ctrl is RoundedButton rb)
                            rb.CornerRadius = new CornerRadius(8);
                        else if (ctrl is IconButton ib)
                            ib.CornerRadius = new CornerRadius(8);
                        break;
                }
            }
        }
    }
}
