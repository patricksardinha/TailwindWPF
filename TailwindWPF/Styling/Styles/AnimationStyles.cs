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
        public override Dictionary<string, Action<Control>> GetStyles() => new()
        {
            ["animate-pulse"] = c =>
            {
                var storyboard = new Storyboard();
                var fadeAnimation = new DoubleAnimation(1.0, 0.5, TimeSpan.FromSeconds(1))
                {
                    AutoReverse = true,
                    RepeatBehavior = RepeatBehavior.Forever
                };
                Storyboard.SetTarget(fadeAnimation, c);
                Storyboard.SetTargetProperty(fadeAnimation, new PropertyPath("Opacity"));
                storyboard.Children.Add(fadeAnimation);
                storyboard.Begin();
            }
        };
    }
}
