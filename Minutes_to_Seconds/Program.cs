using System;

namespace MinutesArray_to_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] SecondsArray = new double[6] { 1, 2, 5, 10, 30, 60 };
            double[] MinutesArray = new double[6];
            string Minute;
            string Second;


            for (int x = 0; x <= 5; x++)
            {
                MinutesArray[x] = TimeSpanUtil.ConvertMinutesToSeconds(SecondsArray, x);
                Minute = MinutesArray[x].ToString();
                Second = SecondsArray[x].ToString();
                Console.WriteLine(Minute, " Minutes is equal to ", Second);
            }

            Console.WriteLine("press any key to continue");
            Console.ReadKey();

        }

        public static class TimeSpanUtil
        {
            public static double ConvertMinutesToSeconds(double[] SecondsArray, int x)
            {
                return TimeSpan.FromMinutes(SecondsArray[x]).TotalSeconds;
            }
        }
    }
}