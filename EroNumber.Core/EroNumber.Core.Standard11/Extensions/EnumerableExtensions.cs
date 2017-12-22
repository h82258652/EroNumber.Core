using System;
using System.Collections.Generic;
using System.Numerics;

namespace EroNumber.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<long> Range(long start, long count)
        {
            var max = (BigInteger)start + count - 1;
            if (count < 0 || max > long.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            for (var i = start; i < start + count; i++)
            {
                yield return i;
            }
        }

        public static IEnumerable<BigInteger> Range(BigInteger start, BigInteger count)
        {
            var max = start + count - 1;
            if (count < 0 || max > long.MaxValue)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            for (var i = start; i < start + count; i++)
            {
                yield return i;
            }
        }
    }
}