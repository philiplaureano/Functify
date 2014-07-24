using System;

namespace Functify
{
    public static class ActionCurryingExtensions
    {
        public static Action Bind<T1>(this Action<T1> action, T1 argument)
        {
            return () => action(argument);
        }

        public static Action<T1> Bind<T1, T2>(this Action<T1, T2> action, T2 argument)
        {
            return openArg => action(openArg, argument);
        }

        public static Action<T1, T2> Bind<T1, T2, T3>(this Action<T1, T2, T3> action, T3 argument)
        {
            return (openArg1, openArg2) => action(openArg1, openArg2, argument);
        }

        public static Action<T1, T2, T3> Bind<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T4 argument)
        {
            return (openArg1, openArg2, openArg3) => action(openArg1, openArg2, openArg3, argument);
        }

        public static Action<T1, T2, T3, T4> Bind<T1, T2, T3, T4, T5>(
            this Action<T1, T2, T3, T4, T5> action,
            T5 argument)
        {
            return (openArg1, openArg2, openArg3, openArg4) => action(openArg1, openArg2, openArg3, openArg4, argument);
        }

        public static Action<T1, T2, T3, T4, T5> Bind<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> action,
            T6 argument)
        {
            return
                (openArg1, openArg2, openArg3, openArg4, openArg5) =>
                    action(openArg1, openArg2, openArg3, openArg4, openArg5, argument);
        }

        public static Action<T1, T2, T3, T4, T5, T6> Bind<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> action,
            T7 argument)
        {
            return
                (openArg1, openArg2, openArg3, openArg4, openArg5, openArg6) =>
                    action(openArg1, openArg2, openArg3, openArg4, openArg5, openArg6, argument);
        }

        public static Action<T1, T2, T3, T4, T5, T6, T7> Bind<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Action<T1, T2, T3, T4, T5, T6, T7, T8> action,
            T8 argument)
        {
            return
                (openArg1, openArg2, openArg3, openArg4, openArg5, openArg6, openArg7) =>
                    action(openArg1, openArg2, openArg3, openArg4, openArg5, openArg6, openArg7, argument);
        }
    }
}