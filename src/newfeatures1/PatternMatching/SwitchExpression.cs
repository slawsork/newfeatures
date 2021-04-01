namespace newfeatures1.PatternMatching
{
    public class SwitchExpression
    {
        public static string SelectValueInOldestWay(int input)
        {
            switch (input)
            {
                case 1:
                    return "First";
                case 2:
                    return "Second";
                default:
                    return "Other";
            }
        }
        
        // new c# 8 feature
        public static string SelectValueInOldWay(int input) =>
            input switch
            {
                1 => "First",
                2 => "Second",
                _ => "Other"
            };
    }
}