using System;
using System.Collections.Generic;

namespace EnumeratorLibrary
{
    public static class TmsLinqExtensions
    {
        public static IEnumerable<TOut> TmsSelect<TIn, TOut>(this IEnumerable<TIn> source, Func<TIn, TOut> selector)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (selector == null)
            {
                throw new ArgumentNullException(nameof(selector));
            }

            throw new NotImplementedException();
            //return new SelectEnumerator();
        }

        public static IEnumerable<TIn> TmsWhere<TIn>(this IEnumerable<TIn> source, Func<TIn, bool> selector)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (selector == null)
            {
                throw new ArgumentNullException(nameof(selector));
            }

            throw new NotImplementedException();
            //return new WhereEnumerator();
        }

        public static IEnumerable<TIn> TmsAggregate<TIn>(this IEnumerable<TIn> source, Func<TIn, TIn, TIn> selector)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (selector == null)
            {
                throw new ArgumentNullException(nameof(selector));
            }

            throw new NotImplementedException();
            //return new AggregateEnumerator();
        }
    }
}