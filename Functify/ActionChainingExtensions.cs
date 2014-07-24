using System;

namespace Functify
{
    public static class ActionChainingExtensions
    {
        public static Action Then(this Action action, Action additionalAction)
        {
            return () =>
            {
                action();
                additionalAction();
            };
        }

        public static Action<T1> Then<T1>(this Action<T1> action, Action<T1> additionalAction)
        {
            return target =>
            {
                action(target);
                additionalAction(target);
            };
        }

        public static Action<T1, T2> Then<T1, T2>(this Action<T1, T2> action, Action<T1, T2> additionalAction)
        {
            return (arg1, arg2) =>
            {
                action(arg1, arg2);
                additionalAction(arg1, arg2);
            };
        }

        public static Action<T1, T2, T3> Then<T1, T2, T3>(this Action<T1, T2, T3> action,
            Action<T1, T2, T3> additionalAction)
        {
            return (arg1, arg2, arg3) =>
            {
                action(arg1, arg2, arg3);
                additionalAction(arg1, arg2, arg3);
            };
        }

        public static Action<T1, T2, T3, T4> Then<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action,
            Action<T1, T2, T3, T4> additionalAction)
        {
            return (arg1, arg2, arg3, arg4) =>
            {
                action(arg1, arg2, arg3, arg4);
                additionalAction(arg1, arg2, arg3, arg4);
            };
        }

        public static Action<T1, T2, T3, T4, T5> Then<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action,
            Action<T1, T2, T3, T4, T5> additionalAction)
        {
            return (arg1, arg2, arg3, arg4, arg5) =>
            {
                action(arg1, arg2, arg3, arg4, arg5);
                additionalAction(arg1, arg2, arg3, arg4, arg5);
            };
        }

        public static Action<T1, T2, T3, T4, T5, T6> Then<T1, T2, T3, T4, T5, T6>(
            this Action<T1, T2, T3, T4, T5, T6> action, Action<T1, T2, T3, T4, T5, T6> additionalAction)
        {
            return (arg1, arg2, arg3, arg4, arg5, arg6) =>
            {
                action(arg1, arg2, arg3, arg4, arg5, arg6);
                additionalAction(arg1, arg2, arg3, arg4, arg5, arg6);
            };
        }

        public static Action<T1, T2, T3, T4, T5, T6, T7> Then<T1, T2, T3, T4, T5, T6, T7>(
            this Action<T1, T2, T3, T4, T5, T6, T7> action, Action<T1, T2, T3, T4, T5, T6, T7> additionalAction)
        {
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) =>
            {
                action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                additionalAction(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            };
        }
    }
}