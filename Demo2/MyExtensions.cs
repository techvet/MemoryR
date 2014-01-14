using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo2
{
    public static class MyExtensions
    {
        static readonly Random Random = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int count = list.Count;
            while (count > 1)
            {
                count--;
                var nextRandNum = Random.Next(count + 1);
                T value = list[nextRandNum];
                list[nextRandNum] = list[count];
                list[count] = value;
            }
        }
    }
}