using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functify
{
    public static class ArrayToExplicitArgumentConversionExtensions
    {
        public static Func<TResult> BindToArray<T1, TResult>(this Func<T1[], TResult> builderFunc, T1 arg1)
        {
            return () => builderFunc(new[] { arg1 });
        }

        public static Func<TResult> BindToArray<T1, TResult>(this Func<T1[], TResult> builderFunc, T1 arg1, T1 arg2)
        {
            return () => builderFunc(new[] { arg1, arg2 });
        }
        public static Func<TResult> BindToArray<T1, TResult>(this Func<T1[], TResult> builderFunc, T1 arg1, T1 arg2, T1 arg3)
        {
            return () => builderFunc(new[] { arg1, arg2, arg3 });
        }
        public static Func<TResult> BindToArray<T1, TResult>(this Func<T1[], TResult> builderFunc, T1 arg1, T1 arg2, T1 arg3, T1 arg4)
        {
            return () => builderFunc(new[] { arg1, arg2, arg3, arg4 });
        }

        public static Func<TResult> BindToArray<T1, TResult>(this Func<T1[], TResult> builderFunc, T1 arg1, T1 arg2, T1 arg3, T1 arg4, T1 arg5)
        {
            return () => builderFunc(new[] { arg1, arg2, arg3, arg4, arg5 });
        }

        public static Func<TResult> BindToArray<T1, TResult>(this Func<T1[], TResult> builderFunc, T1 arg1, T1 arg2, T1 arg3, T1 arg4, T1 arg5, T1 arg6)
        {
            return () => builderFunc(new[] { arg1, arg2, arg3, arg4, arg5, arg6 });
        }

        public static Func<TResult> BindToArray<T1, TResult>(this Func<T1[], TResult> builderFunc, T1 arg1, T1 arg2, T1 arg3, T1 arg4, T1 arg5, T1 arg6, T1 arg7)
        {
            return () => builderFunc(new[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7 });
        }
        public static Func<TResult> BindToArray<T1, TResult>(this Func<T1[], TResult> builderFunc, T1 arg1, T1 arg2, T1 arg3, T1 arg4, T1 arg5, T1 arg6, T1 arg7, T1 arg8)
        {
            return () => builderFunc(new[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8 });
        }
        public static Func<TResult> BindToArray<T1, TResult>(this Func<T1[], TResult> builderFunc, T1 arg1, T1 arg2, T1 arg3, T1 arg4, T1 arg5, T1 arg6, T1 arg7, T1 arg8, T1 arg9)
        {
            return () => builderFunc(new[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9 });
        }
        public static Func<TResult> BindToArray<T1, TResult>(this Func<T1[], TResult> builderFunc, T1 arg1, T1 arg2, T1 arg3, T1 arg4, T1 arg5, T1 arg6, T1 arg7, T1 arg8, T1 arg9, T1 arg10)
        {
            return () => builderFunc(new[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10 });
        }
        public static Func<TResult> BindToArray<T1, TResult>(this Func<T1[], TResult> builderFunc, T1 arg1, T1 arg2, T1 arg3, T1 arg4, T1 arg5, T1 arg6, T1 arg7, T1 arg8, T1 arg9, T1 arg10, T1 arg11)
        {
            return () => builderFunc(new[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11 });
        }

        public static Func<TResult> BindToArray<T1, TResult>(this Func<T1[], TResult> builderFunc, T1 arg1, T1 arg2, T1 arg3, T1 arg4, T1 arg5, T1 arg6, T1 arg7, T1 arg8, T1 arg9, T1 arg10, T1 arg11, T1 arg12)
        {
            return () => builderFunc(new[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12 });
        }

        public static Func<TResult> BindToArray<T1, TResult>(this Func<T1[], TResult> builderFunc, T1 arg1, T1 arg2, T1 arg3, T1 arg4, T1 arg5, T1 arg6, T1 arg7, T1 arg8, T1 arg9, T1 arg10, T1 arg11, T1 arg12, T1 arg13)
        {
            return () => builderFunc(new[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13 });
        }

        public static Func<TResult> BindToArray<T1, TResult>(this Func<T1[], TResult> builderFunc, T1 arg1, T1 arg2, T1 arg3, T1 arg4, T1 arg5, T1 arg6, T1 arg7, T1 arg8, T1 arg9, T1 arg10, T1 arg11, T1 arg12, T1 arg13, T1 arg14)
        {
            return () => builderFunc(new[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14 });
        }

        public static Func<TResult> BindToArray<T1, TResult>(this Func<T1[], TResult> builderFunc, T1 arg1, T1 arg2, T1 arg3, T1 arg4, T1 arg5, T1 arg6, T1 arg7, T1 arg8, T1 arg9, T1 arg10, T1 arg11, T1 arg12, T1 arg13, T1 arg14, T1 arg15)
        {
            return () => builderFunc(new[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15 });
        }

        public static Func<TResult> BindToArray<T1, TResult>(this Func<T1[], TResult> builderFunc, T1 arg1, T1 arg2, T1 arg3, T1 arg4, T1 arg5, T1 arg6, T1 arg7, T1 arg8, T1 arg9, T1 arg10, T1 arg11, T1 arg12, T1 arg13, T1 arg14, T1 arg15, T1 arg16)
        {
            return () => builderFunc(new[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16 });
        }
    }
}
