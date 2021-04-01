using System;
using System.Collections.Generic;

namespace newfeatures1.TargetTyping
{
    public static class TargetTypingExample
    {
        public static void Show()
        {
            // new expressions
            var shop = new ComicsShop("NY");

            ComicsShop shop2 = new("LA");

            var newShop = CreateShop(new (1999, 12, 01), "Warsaw");

            GetAllShops();
            
            // shared types
            var numbers = GetNumbers(even: true);
            
            // target types 
            int? result = true ? /*(int?)*/0 : null;

        }

        private static Shop ShopFactory(object o)
        {
            throw new NotImplementedException();
        }

        private static IEnumerable<int> GetNumbers(bool even)
        {
            return even ? /*(IEnumerable<int>)*/ new List<int> {2, 4, 6} : new [] {1, 3, 5};
        }

        private static IEnumerable<ComicsShop> GetAllShops()
        {
            return new ComicsShop[]
            {
                new() {CityAddress = "Vilnius"},
                new() {CityAddress = "Riga"}
            };
        }

        private static ComicsShop CreateShop(DateTime dateCreated, string city)
        {
            return new() { CreatedDate = dateCreated, CityAddress = city};
        }
    }
}