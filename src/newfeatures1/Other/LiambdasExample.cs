using System;

namespace newfeatures1.Other
{
    public class LiambdasExample
    {
        private static void SomeFunc(Func<int, int> f)
        {
            Console.WriteLine(f(5));
        }
        
        public static void Show()
        {
            int y1 = 10;
            const int y2 = 10;
            SomeFunc(i => i + y1);          
            //SomeFunc(static i => i + y1);   
            SomeFunc(static i => i + y2); // <- c#9 feature
        }
    }
}