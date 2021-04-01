using System;

namespace newfeatures1.PatternMatching
{
    public class NewSwitchExpressions
    {
        public decimal CalculateToll(object vehicle) => 
            vehicle switch
            {
                Car c => 2.00m, // unused c can be replaced with _, and actually removed)
                Taxi t => 3.50m,
                Bus b => 5.00m,
                Truck t => 10.00m,
                { } => throw new ArgumentException("Unknown vehicle type", nameof(vehicle)), // new: empty object checj
                null => throw new ArgumentNullException(nameof(vehicle)) // new null check instead of _
            };
        
        public static decimal FullCalculateToll(object vehicle) =>
            vehicle switch
            {
                Car c => c.Passengers switch
                {
                    0 => 2.00m + 0.5m,
                    1 => 3.00m + 0.5m,
                    _ => 2.00m - 1.0m
                },

                Taxi t => t.Fares switch
                {
                    0 => 3.50m + 1.00m,
                    _ => 3.50m - 1.00m
                },

                Bus b when ((double)b.Riders / (double)b.Capacity) < 0.50 => 5.00m + 2.00m,
                Bus => 5.00m,

                Truck {GrossWeightClass: >= 5000} => 10.00m + 5.00m,
                Truck => 8.00m,

                { } => throw new ArgumentException("Unknown vehicle type", nameof(vehicle)),
                null => throw new ArgumentNullException(nameof(vehicle)),
            };
        
        // 8
        public static string GetTimeBandDependOnSeasonOld(DateTime timeOfToll, string season) =>
            (timeOfToll.Hour, season) switch
            {
                (6, "summer") => "Overnight",
                (7, "summer") => "MorningRush",
                (8, "winter") => "Overnight",
                _ => "EveningRush",
            };
        
        // 9
        public static string GetTimeBandDependOnSeason(DateTime timeOfToll, string season) =>
            (timeOfToll.Hour, season) switch
            {
                (< 6 or > 19, "summer") => "Overnight",
                (< 10, "summer") => "MorningRush",
                (< 9 or > 17, "winter") => "Overnight",
                _ => "EveningRush",
            };
    }
}