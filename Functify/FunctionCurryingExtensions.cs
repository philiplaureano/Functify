using System;

namespace Functify
{
    public static class FunctionCurryingExtensions
    {
        public static Func<TResult> Bind<T1, TResult>(this Func<T1, TResult> function, T1 argument)
        {
            return () => function(argument);
        }

        public static Func<T1, TResult> Bind<T1, T2, TResult>(this Func<T1, T2, TResult> function, T2 argument)
        {
            return openArg => function(openArg, argument);
        }

        public static Func<T1, T2, TResult> Bind<T1, T2, T3, TResult>(
            this Func<T1, T2, T3, TResult> function,
            T3 argument)
        {
            return (openArg1, openArg2) => function(openArg1, openArg2, argument);
        }

        public static Func<T1, T2, T3, TResult> Bind<T1, T2, T3, T4, TResult>(
            this Func<T1, T2, T3, T4, TResult> function,
            T4 argument)
        {
            return (openArg1, openArg2, openArg3) => function(openArg1, openArg2, openArg3, argument);
        }

        public static Func<T1, T2, T3, T4, TResult> Bind<T1, T2, T3, T4, T5, TResult>(
            this Func<T1, T2, T3, T4, T5, TResult> function,
            T5 argument)
        {
            return
                (openArg1, openArg2, openArg3, openArg4) => function(openArg1, openArg2, openArg3, openArg4, argument);
        }

        public static Func<T1, T2, T3, T4, T5, TResult> Bind<T1, T2, T3, T4, T5, T6, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, TResult> function,
            T6 argument)
        {
            return
                (openArg1, openArg2, openArg3, openArg4, openArg5) =>
                    function(openArg1, openArg2, openArg3, openArg4, openArg5, argument);
        }

        public static Func<T1, T2, T3, T4, T5, T6, TResult> Bind<T1, T2, T3, T4, T5, T6, T7, TResult>(
            this Func<T1, T2, T3, T4, T5, T6, T7, TResult> function,
            T7 argument)
        {
            return
                (openArg1, openArg2, openArg3, openArg4, openArg5, openArg6) =>
                    function(openArg1, openArg2, openArg3, openArg4, openArg5, openArg6, argument);
        }
    }
}