using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    public class DayOfWeeek
    {
       public static void FindDay()
       {
            //Variables.
            int month, day, year, x, y, m, d;
            //Taking input from user
            Console.WriteLine("Enter Date");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of month ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            year = Convert.ToInt32(Console.ReadLine());
                      
            y = year - (14 - month) / 12;
            x = y + y / 4 - y / 100 + y / 400;
            m = month + 12 * ((14 - month) / 12) - 2;
            d = (day + x + 31 * m / 12) % 7;
            Console.WriteLine(d);
            DayOfWeeek.day(d);
        }
       public static void day(int d)
        {
            //switch case for get week day
            switch(d)
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
