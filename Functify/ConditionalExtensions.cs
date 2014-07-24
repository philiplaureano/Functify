using System;

namespace Functify
{
    public static class ConditionalExtensions
    {
        public static Func<TSubject> WhenTrue<TSubject>(this TSubject subject, Func<TSubject, bool> condition,
            Action<TSubject> action)
        {
            Func<TSubject> getSubject = () => subject;
            return WhenTrue(getSubject, condition, action);
        }

        public static Func<TSubject> WhenFalse<TSubject>(this TSubject subject, Func<TSubject, bool> condition,
            Action<TSubject> action)
        {
            Func<TSubject> getSubject = () => subject;
            return WhenFalse(getSubject, condition, action);
        }

        public static Func<TSubject> WhenTrue<TSubject>(this Func<TSubject> function, Func<TSubject, bool> condition,
            Action<TSubject> action)
        {
            return () =>
            {
                var subject = function();
                if (condition(subject))
                    action(subject);

                return subject;
            };
        }

        public static Func<TSubject> WhenFalse<TSubject>(this Func<TSubject> function, Func<TSubject, bool> condition,
            Action<TSubject> action)
        {
            return () =>
            {
                var subject = function();
                if (!condition(subject))
                    action(subject);

                return subject;
            };
        }
    }
}