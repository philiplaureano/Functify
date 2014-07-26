using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinFu.Delegates.Partial;

namespace Functify
{
    public static class PartialApplicationExtensions
    {
        public static TDelegate Partial<TDelegate>(this MulticastDelegate func, params object[] arguments)
            where TDelegate : class
        {
            return CreateDelegate<TDelegate>(func, arguments);
        }

        private static TDelegate CreateDelegate<TDelegate>(MulticastDelegate theDelegate, object[] arguments)
            where TDelegate : class
        {
            var partialApp = new PartialApplication(theDelegate, arguments);
            return partialApp.AdaptTo<TDelegate>();
        }
    }
}
