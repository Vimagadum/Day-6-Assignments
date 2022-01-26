using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPrograms
{
    public class CouponNumber
    {
        public int count = 0;
        public void Generate()
        {            
            Console.WriteLine("How Many coupans you want to generate");
            int num = Convert.ToInt32(Console.ReadLine());
            //declaring array
            int[] arr = new int[num];
            
            for (int i = 0; i < num; i++)
            {
                //generating random value
                Random random = new Random();
                int value = random.Next(10,20);
                count++;
                
                //Iteratinng each value from the array
                foreach(int c in arr)
                {
                    while(c==value)
                    {
                        value = random.Next(10, 20);                        
                        count++;
                    }                    
                }
                //finally Storing the generated unique numbers 
                arr[i]=value;
            }
            //Iterating values and printing 
            foreach (int valuee in arr)
            {
                Console.WriteLine(valuee);
            }
            Console.WriteLine("Random number generated for : {0} times", count);
        }        
    }
}
