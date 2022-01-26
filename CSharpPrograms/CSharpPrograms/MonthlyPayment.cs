using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    public class MonthlyPayment
    {
        public static void Payment()
        {
            //Taking user input
            Console.WriteLine("Enter years ");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter principal loan amount");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter percent interest monthly");
            double R = Convert.ToDouble(Console.ReadLine());

            double n = 12 * Y;
            double r = R / (12 * 100);
            //calculating payment
            double payment =(P * r)/(1 -  Math.Pow((1 + r),(-1*n)));
            
            
            Console.WriteLine(payment);
        }

    }
}
