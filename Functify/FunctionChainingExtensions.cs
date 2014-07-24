using System;

namespace Functify
{
    public static class FunctionChainingExtensions
    {
        public static Func<TSubject> Then<TSubject>(this TSubject subject, Action<TSubject> action)
        {
            var currentSubject = subject;
            Func<TSubject> getSubject = () => currentSubject;
            return getSubject.Then(action);
        }

        public static Func<TResult> Return<TSubject, TResult>(this Func<TSubject> function, Func<TSubject, TResult> projection)
        {
            return () => projection(function());
        }

        public static Func<TSubject> Then<TSubject>(this Func<TSubject> function, Action<TSubject> action)
        {
            return () =>
            {
                var subject = function();
                action(subject);

                return subject;
            };
        }
    }
}