namespace SeminarHelper
{
    static class PrintHelper
    {
        public static string DayToString(int day)
        {
            return day switch
            {
                0 => "Po",
                1 => "Út",
                2 => "St",
                3 => "Čt",
                4 => "Pá",
                -1 => "None",
                _ => "Missing"
            };
        }

        public static string TimeToString(int first, int second)
        {
            return $"{first}:00-{second}:50";
        }

        public static string Periodicity(bool even, bool odd)
        {
            if (even && odd)
            {
                return "každé";
            }
            else if (even)
            {
                return "sudé";
            }
            else if (odd)
            {
                return "liché";
            }
            return "Fucked up once again";
        }
    }
}
