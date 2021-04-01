namespace newfeatures1.InitSetters
{
    public class InitSettersExample
    {
        public static void Show()
        {
            var oldSchool = new OldSchool(123);
            
            var newSchool = new NewSchool
            {
                Number = 124,
                Address = "NY, 27872"
            };

            //newSchool.Number = 125;
            //newSchool.Address = "new address";


            var newestSchool = new NewestSchool
            {
                Number = 125
            };

            //newestSchool.Number = 126;
        }
    }
}