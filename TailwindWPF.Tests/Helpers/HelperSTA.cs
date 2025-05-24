using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailwindWPF.Tests.Helpers
{
    public class HelperSTA
    {
        public static T RunInSta<T>(Func<T> action)
        {
            T result = default(T);
            var thread = new Thread(() => result = action());
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
            return result;
        }

        public static void RunInSta(Action action)
        {
            var thread = new Thread(() => action());
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
    }
}
