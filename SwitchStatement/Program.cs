using System;

namespace SwitchStatement
{
    class Program
    {
        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "sunday";
                    break;
                case 1:
                    dayName = "momnday";
                    break;
                case 2:
                    dayName = "tuesday";
                    break;
                case 3:
                    dayName = "wednesday";
                    break;
                case 4:
                    dayName = "thursday";
                    break;
                case 5:
                    dayName = "friday";
                    break;
                case 6:
                    dayName = "saturday";
                    break;
                default:
                    dayName = "Invalid date";
                    break;
            }

            return dayName;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter date from 0 - 6 (others return error): ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetDay(date));

            Console.ReadLine();
        }
    }
}
