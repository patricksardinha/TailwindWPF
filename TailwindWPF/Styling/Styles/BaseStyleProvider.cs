using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TailwindWPF.Styling.Styles
{
    public abstract class BaseStyleProvider : IStyleProvider
    {
        public abstract Dictionary<string, Action<DependencyObject>> GetStyles();

        protected static SolidColorBrush CreateBrush(string hex) =>
            new SolidColorBrush((Color)ColorConverter.ConvertFromString(hex));
    }
}
