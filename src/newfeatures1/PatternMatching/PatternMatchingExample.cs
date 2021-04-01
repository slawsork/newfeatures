using System;
using System.Collections.Generic;
using System.Linq;

namespace newfeatures1.PatternMatching
{
    public class PatternMatchingExample
    {
        public static void Show()
        {
            Console.WriteLine(NewSwitchExpressions.FullCalculateToll(new Bus { Riders = 10, Capacity = 25})); // 7.0m
            Console.WriteLine(NewSwitchExpressions.GetTimeBandDependOnSeason(DateTime.Now, "summer"));
            
            var vehicles = new List<Vehicle>() {new Car(), new Bus(), new Taxi()};
            var some = vehicles.First();

            if (!(some is Bus))
            {
                Console.WriteLine("old: It's not a bus");
            }

            if (some is not Bus)
            {
                Console.WriteLine("new: It's not a bus");
            }
            
            if (some is not null)
            {
                Console.WriteLine("new: It's not a null bus");
            }

            var bus = new Bus { Riders = 9, Capacity = 12};
            if (bus is { Riders: < 10, Capacity: > 10 and < 20})
            {
                Console.WriteLine("Quite small but comfortable bus");
            }
        }
    }
}