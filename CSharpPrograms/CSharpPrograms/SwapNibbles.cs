using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    public class SwapNibbles
    {
        public static void Binaryy()
        {
            //Asking user to enter decimal number
            Console.Write("Enter the Decimal Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter same number again");
            int num = Convert.ToInt32(Console.ReadLine());
            int i;
            int j;
            //Declaring for loop to just get to know how many times loop going to be iterate and giving that number to array index
            for (i = 0; number > 0; i++)
            {
                number = number / 2;

            }
            //creating array
            int[] numberArray = new int[i];

            for (j = 0; num > 0; j++)
            {
                numberArray[j] = num % 2;
                num = num / 2;
            }
            //making array in reverse
            Array.Reverse(numberArray);
            //iterating each value from array and printing it
            foreach (int bin in numberArray)
            {
                Console.Write(bin);
            }

            //int[] secArr = new int[num*2];
            //int[] value = (numberArray.Length / 2);
            //int q = value % 2;
            //for (int m=0; m < q; m++)
            //{
            //    foreach (int b in value)
            //    {
            //        Console.WriteLine(b);
            //        secArr[i] = b;
            //        foreach (int c in secArr)
            //        {
            //            Console.WriteLine(c);
            //        }
            //    }
            //}
            //int x = q - numberArray.Length;
            //foreach (int y in numberArray)
            //{
            //    Console.WriteLine(y);
            //}

        }
    }
}
