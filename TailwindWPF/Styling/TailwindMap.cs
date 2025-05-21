using System;
using System.Collections.Generic;
using System.Windows.Controls;

using TailwindWPF.Styling.Styles;

namespace TailwindWPF.Styling
{
    public static class TailwindMap
    {
        public static readonly Dictionary<string, Action<Control>> ClassMap = new();

        static TailwindMap()
        {
            // Merge all dictionnaries
            foreach (var kv in CommonStyles.Map)
                ClassMap[kv.Key] = kv.Value;
            foreach (var kv in ButtonStyles.Map)
                ClassMap[kv.Key] = kv.Value;
        }        
    }
}
