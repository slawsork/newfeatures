using System;
using System.Collections.Generic;

namespace newfeatures1.Other
{
    public static class GetEnumeratorExtensionExample
    {
        public static void Show()
        {
            foreach(var item in ("Have", "a", "nice", "day", "!"))
            {
                Console.WriteLine(item);
            }
        }
        
        private static IEnumerator<T> GetEnumerator<T>(this ValueTuple<T, T, T, T, T> source) // <- c#9 feature
        {
            yield return source.Item1;
            yield return source.Item2;
            yield return source.Item3;
            yield return source.Item4;
            yield return source.Item5;
        }
    }
}