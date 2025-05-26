using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TailwindWPF.Styling
{
    public static class CornerRadiusHelper
    {
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(CornerRadiusHelper), new FrameworkPropertyMetadata(new CornerRadius(0), FrameworkPropertyMetadataOptions.Inherits));

        public static void SetCornerRadius(DependencyObject element, CornerRadius value) =>
            element.SetValue(CornerRadiusProperty, value);

        public static CornerRadius GetCornerRadius(DependencyObject element) =>
            (CornerRadius)element.GetValue(CornerRadiusProperty);
    }
}
