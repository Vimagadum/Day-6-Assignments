using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    public class PerfectNumber
    {
        public static void Number()
        {
            Console.WriteLine("Enter Number to check the number if perfect number or not");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            //loop for repeat the loop untill i reaches half of the given numnber 
            for(int i = 1; i <= number/2; i++)
            {
                //checking modulas 
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                else
                {
                    Console.WriteLine("remainder is not equal to zero");
                }
            }
            //checking sum of dividers are equal to given number or not
            if (sum == number)
            {
                Console.WriteLine(number + " is Perfect Number");
            }
            else
            {
                Console.WriteLine(number + " is not perfect number");
            }

        }
    }
}
