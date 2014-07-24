using System;
using System.Collections.Generic;
using System.Linq;

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

        public static Func<T, B> Compose<T, A, B>(this Func<T, A> f, Func<A, B> selector)
        {
            return f.Select(selector);
        }

        public static Func<T, B> Select<T, A, B>(this Func<T, A> f, Func<A, B> selector)
        {
            return t => selector(f(t));
        }

        public static Func<T, B> SelectMany<T, A, B>(this Func<T, A> f, Func<A, Func<T, B>> selector)
        {
            return t => selector(f(t))(t);
        }

        public static Func<T, C> SelectMany<T, A, B, C>(this Func<T, A> f, Func<A, Func<T, B>> selector, Func<A, B, C> combine)
        {
            return SelectMany(f, a => selector(a).Select(b => combine(a, b)));
        }

        public static Func<A, C> Then<A, B, C>(this Func<A, B> f, Func<B, C> g)
        {
            return f.Select(g);
        }

        public static Func<T, IEnumerable<A>> Sequence<T, A>(this IEnumerable<Func<T, A>> fns)
        {
            return t => fns.Select(fn => fn(t));
        }

        public static Func<T, B> Apply<T, A, B>(this Func<T, A, B> f, Func<T, A> g)
        {
            return t => f(t, g(t));
        }

        public static Func<T, A> Join<T, A>(this Func<T, Func<T, A>> f)
        {
            return f.SelectMany(x => x);
        }
    }
}