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
    public static class MethodFinderExtensions
    {
        public static TMethod GetBestMatch<TMethod>(this IEnumerable<TMethod> targetMethods, string methodName, Type[] typeArguments, object[] args)
            where TMethod : MethodBase
        {
            var hasTypeArguments = typeArguments != null && typeArguments.Length > 0;
            Func<MethodBase, int, Type, bool> matchesParameterType = (method, index, type) =>
            {
                var result = false;
                try
                {
                    var currentMethod = method;
                    if (hasTypeArguments && method is MethodInfo)
                    {
                        var methodInfo = (MethodInfo)method;
                        currentMethod = methodInfo.MakeGenericMethod(typeArguments ?? new Type[0]);
                    }

                    var parameters = currentMethod.GetParameters();
                    var parameter = index < parameters.Length ? parameters[index] : null;
                    result = parameter != null && type.IsAssignableFrom(parameter.ParameterType);
                }
                catch
                {
                    // Ignore the error
                }

                return result;
            };

            var candidateMethods = targetMethods.AsFuzzyList();
            var expectedArgumentCount = args != null ? args.Length : 0;

            if (typeof(TMethod) != typeof(ConstructorInfo) && hasTypeArguments)
            {
                // Match the type argument count, if necessary
                candidateMethods.AddCriteria(m => m.IsGenericMethodDefinition &&
                    m.GetGenericArguments().Length == typeArguments.Length, CriteriaType.Critical);
            }

            // Match the method name
            candidateMethods.AddCriteria(m => m.Name == methodName, CriteriaType.Critical);

            // Match the argument count
            var arguments = args ?? new object[0];
            for (var i = 0; i < expectedArgumentCount; i++)
            {
                var currentArgument = arguments[i];

                // Match the argument types
                var currentIndex = i;
                if (currentArgument != null)
                {
                    candidateMethods.AddCriteria(
                        m => matchesParameterType(m, currentIndex, currentArgument.GetType()),
                        CriteriaType.Critical);
                }
            }

            var bestMatch = candidateMethods.BestMatch();
            MethodBase targetMethod = bestMatch != null ? bestMatch.Item : null;

            // Instantiate the generic method if necessary
            if (typeof(TMethod) == typeof(MethodInfo) && hasTypeArguments && bestMatch != null && targetMethod is MethodInfo)
            {
                var targetMethodInfo = targetMethod as MethodInfo;
                targetMethod = targetMethodInfo.MakeGenericMethod(typeArguments);
            }

            return (TMethod)targetMethod;
        }
    }
}
