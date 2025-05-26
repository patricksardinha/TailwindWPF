using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TailwindWPF.Styling.Styles
{
    public class HoverStyles : BaseStyleProvider
    {
        public override Dictionary<string, Action<DependencyObject>> GetStyles() => new()
        {
            ["hover:bg-blue-600"] = e =>
            {
                if (e is Control control)
                {
                    var originalBrush = control.Background;
                    control.MouseEnter += (s, ev) => control.Background = CreateBrush("#2563EB");
                    control.MouseLeave += (s, ev) => control.Background = originalBrush;
                }
            },
        };
    }
}
