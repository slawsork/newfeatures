using System;

namespace newfeatures1
{
    public class RecordsExample
    {
        public static void Show()
        {
            var starwars = new Movie
            {
                Title = "Star Wars I",
                Rating = 8  
            };

            var starwarsSame = new Movie
            {
                Title = "Star Wars I",
                Rating = 8
            };

            //starwarsSame.Title = "Star Wars II";
            var starwars2 = starwarsSame with { Title = "Star Wars II" };

            var jimCarry = new Actor
            {
                Name = "Jim Carrey",
                Age = 59
            };

            var jimCarry2 = new Actor
            {
                Name = "Jim Carrey",
                Age = 59
            };

            Console.WriteLine("same classes comparing: " + jimCarry.Equals(jimCarry2)); // compare by reference 
            Console.WriteLine("same records comparing: " + starwars.Equals(starwarsSame)); // compare by state
            Console.WriteLine("not same records comparing: " + starwars.Equals(starwars2)); 
            
            Console.WriteLine(jimCarry);
            Console.WriteLine(starwars);

            Console.WriteLine("same classes comparing through ==: " + (jimCarry == jimCarry2));
            Console.WriteLine("same records comparing through ==: " + (starwars == starwarsSame));


            var starwarsSeries = new TvSeries {Title = "Star Wars I", Rating = 8 };
            Console.WriteLine("inherited records comparing: " + (starwars == starwarsSeries));

            var mydog = new Pet("Dog","Vinny");
            
            Console.WriteLine(mydog);
            Console.WriteLine(mydog.Name);
            var (type, _) = mydog;
            Console.WriteLine(type);
            mydog.SomeAction();
            //Console.WriteLine(starwars == mydog);
        }
    }
}