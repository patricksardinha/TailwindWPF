using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows;

namespace TailwindWPF.Styling.Styles
{
    public class AnimationStyles : BaseStyleProvider
    {
        public override Dictionary<string, Action<DependencyObject>> GetStyles() => new()
        {
            ["animate-pulse"] = e =>
            {
                if (e is UIElement element)
                {
                    var storyboard = new Storyboard();
                    var fadeAnimation = new DoubleAnimation(1.0, 0.5, TimeSpan.FromSeconds(1))
                    {
                        AutoReverse = true,
                        RepeatBehavior = RepeatBehavior.Forever
                    };
                    Storyboard.SetTarget(fadeAnimation, element);
                    Storyboard.SetTargetProperty(fadeAnimation, new PropertyPath("Opacity"));
                    storyboard.Children.Add(fadeAnimation);
                    storyboard.Begin();
                }
            }
        };
    }
}
