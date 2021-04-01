using System;

namespace newfeatures1.TargetTyping
{
    public class Shop
    {
        
    }
    
    public class ComicsShop : Shop
    {
        public string CityAddress { get; set; }

        public DateTime CreatedDate { get; set; }

        public ComicsShop(){}
        
        public ComicsShop(string cityAddress)
        {
            CityAddress = cityAddress;
        }
    }

    public class MeatShop : Shop
    {
        
    }
}