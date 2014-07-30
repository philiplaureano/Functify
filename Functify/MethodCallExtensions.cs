using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Functify
{
    public static class MethodCallExtensions
    {
        public static Func<object[], object> CallTo<TTarget>(this TTarget target, string methodName)
        {
            return CreateCallTo(() => target, methodName);
        }

        public static Func<object[], object> CallTo<TTarget>(this Func<TTarget> getTarget, string methodName)
        {
            return CreateCallTo(getTarget, methodName);
        }

        public static Func<Type[], Func<object[], object>> GenericCallTo<TTarget>(this TTarget target, string methodName)
        {
            return typeArgs => CreateCallTo(() => target, methodName, typeArgs);
        }

        public static Func<Type[], Func<object[], object>> GenericCallTo<TTarget>(this Func<TTarget> getTarget, string methodName)
        {
            return typeArgs => getTarget().GenericCallTo(methodName)(typeArgs);
        }

        private static Func<object[], object> CreateCallTo<TTarget>(this Func<TTarget> getTarget, string methodName,
            params Type[] typeArguments)
        {
            const BindingFlags Flags = BindingFlags.Public | BindingFlags.Instance;
            var targetType = typeof(TTarget);
            var targetMethods = targetType.GetMethods(Flags);

            return args =>
            {
                var target = getTarget();

                var targetMethod = targetMethods.GetBestMatch(methodName, typeArguments, args);
                if (targetMethod == null)
                    throw new MissingMethodException(string.Format("Unable to find a method named '{0}' on type '{1}'", methodName, targetType));

                var result = targetMethod.Invoke(target, args);

                return result;
            };
        }

        public static Func<TResult> WithArguments<T1, TResult>(this Func<T1[], TResult> func, params T1[] args)
        {
            return () => func(args);
        }

        public static Func<object[], object> WithTypeArguments(this Func<Type[], Func<object[], object>> genericMethodDefinition,
            params Type[] typeArguments)
        {
            return genericMethodDefinition(typeArguments);
        }
    }
}
