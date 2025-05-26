using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TailwindWPF.Styling.Styles
{
    public class HoverStyles : BaseStyleProvider
    {
        public override Dictionary<string, Action<Control>> GetStyles() => new()
        {
            ["hover:bg-blue-600"] = c => {
                var originalBrush = c.Background;
                c.MouseEnter += (s, e) => c.Background = CreateBrush("#2563EB");
                c.MouseLeave += (s, e) => c.Background = originalBrush;
            },
        };
    }
}
