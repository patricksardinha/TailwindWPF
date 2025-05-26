using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TailwindWPF.Styling
{
    public static class Tw
    {
        public static readonly DependencyProperty ClassProperty =
            DependencyProperty.RegisterAttached("Class", typeof(string), typeof(Tw), new PropertyMetadata(null, OnClassChanged));

        public static void SetClass(DependencyObject element, string value) =>
            element.SetValue(ClassProperty, value);
                
        public static string GetClass(DependencyObject element) =>
            (string)element.GetValue(ClassProperty);

        private static void OnClassChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not Control ctrl || e.NewValue is not string classString)
                return;

            foreach (var cls in classString.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                if (TailwindMap.ClassMap.TryGetValue(cls, out var action))
                {
                    action(ctrl);
                }
            }
        }
    }
}
