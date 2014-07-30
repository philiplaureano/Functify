using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LinFu.Finders;
using LinFu.Finders.Interfaces;

namespace Functify
{
    public class Constructor
    {
        public static Func<object[], TResult> CallTo<TResult>()
        {
            const BindingFlags Flags = BindingFlags.Public | BindingFlags.Instance;

            Func<MethodBase, int, Type, bool> matchesParameterType = (method, index, type) =>
            {
                var parameters = method.GetParameters();
                var parameter = index < parameters.Length ? parameters[index] : null;
                return parameter != null && type.IsAssignableFrom(parameter.ParameterType);
            };

            var constructors = typeof(TResult).GetConstructors(Flags);
            return args =>
            {
                var bestMatch = constructors.GetBestMatch(".ctor", new Type[0], args);
                if (bestMatch == null)
                    throw new MissingMethodException(string.Format("Unable to find a suitable constructor for type '{0}'", typeof(TResult)));

                var constructor = bestMatch;
                return (TResult)constructor.Invoke(args);
            };
        }
    }
}
