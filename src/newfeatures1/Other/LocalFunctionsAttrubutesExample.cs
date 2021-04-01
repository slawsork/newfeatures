using System;
using System.Diagnostics;

namespace newfeatures1.Other
{
    public class LocalFunctionsAttrubutesExample
    {
        public static void Show()
        {
            
            static void SayGreetings(string callee)
            {
                Console.WriteLine($"Greetings from {callee}");
            }
            
#if DEBUG
                SayGreetings("Old school");
#endif
            
            
        }
        
        public static void Show2()
        {
            [Conditional("DEBUG")] // <- c# 9 feature
            static void SayGreetings(string callee)
            {
                Console.WriteLine($"Greetings from {callee}");
            }
            
            SayGreetings("New cool school");
        }
    }
}