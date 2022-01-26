using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    public class VendingMachine
    {
        public static void Notes()
        {
            Console.WriteLine("Enter your cash amount");
            int cash = Convert.ToInt32(Console.ReadLine());
            //storing input in tempcash variable
            int tempCash = cash;
            //declaring array
            int[] availableCash = { 1000, 500, 100, 50, 20, 10, 5, 2, 1 };
            //loop for repeat the process
            for (int i = 0; i < availableCash.Length; i++)
            {
                //checking the given input with the array
                if (cash >= availableCash[i])
                {
                    //deviding the input value by array
                    int noOfNotes = cash/availableCash[i];
                    //taking modulas 
                    cash = cash % availableCash[i];
                    int total = availableCash[i] * noOfNotes;
                    Console.WriteLine(availableCash[i] +"X"+ noOfNotes +"="+ total);
                }
                if (cash == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Total Money = {0}",tempCash);
        }
    }
}
