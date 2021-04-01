namespace newfeatures1.PatternMatching
{
    public class Vehicle
    {
        
    }
    
    public class Car : Vehicle
    {
        public int Passengers { get; set; }
    }

    public class Taxi : Vehicle
    {
        public int Fares { get; set; }
    }

    public class Bus : Vehicle
    {
        public int Riders { get; set; }
        public int Capacity { get; set; }
    }

    public class Truck : Vehicle
    {
        public int GrossWeightClass { get; set; }
    }
}