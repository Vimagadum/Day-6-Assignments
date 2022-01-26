using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    public class TemperaturConversion
    {
        public static void Celsius()
        {
            Console.WriteLine("enter a Fahranheit Value to calculate value to celsius");
            double f = Convert.ToDouble(Console.ReadLine());
            //formula for converting Celsius
            double c = (f - 32) * 5 / 9;
            Console.WriteLine(c);
        }
        public static void Faranheit()
        {
            Console.WriteLine("enter a Celsius Value to calculate Fahranheit value");
            double c = Convert.ToDouble(Console.ReadLine());
            ///formula for converting to faranheit
            double f = (c * 9 / 5) + 32;
            Console.WriteLine(f);
        }


    }
}
