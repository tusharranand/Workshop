using System;

namespace Workshop
{
    class Program
    {
        static int dayOfWeek(int d, int m, int y)
        {
            int y0 = y - (14 - m) / 12;
            int x = y0 * (1 + (1 / 4) - (1 / 100) + (1 / 400));
            int m0 = m + 12 * (( 14 - m ) / 12) - 2;
            return (d + x + 31 * m0 / 12) % 7;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the Number of days: ");
            int d  = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Number of months: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Number of years: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nGiven day is: ");
            switch (dayOfWeek(d,m,y))
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
    }
}
/*

To the Util Class add dayOfWeek static function that takes a date as input and
prints the day of the week that date falls on. Your program should take three
command­line arguments: m (month), d (day), and y (year). For m use 1 for January,
2 for February, and so forth. For output print 0 for Sunday, 1 for Monday, 2 for
Tuesday, and so forth. Use the following formulas, for the Gregorian calendar (where / denotes integer division):
y0 = y − (14 − m) / 12
x = y0 + y0/4 − y0/100 + y0/400
m0 = m + 12 × ((14 − m) / 12) − 2
d0 = (d + x + 31m0/ 12) mod 7

 */