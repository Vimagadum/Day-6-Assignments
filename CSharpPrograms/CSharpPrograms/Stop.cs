using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharpPrograms
{
    public class Stop
    {
        public static void watch()
        {
            //Taking inbuild stop watch class 
            Stopwatch stopWatch = new Stopwatch();
            Console.WriteLine("Press S to start the stop watch");
            string choice = Console.ReadLine();
            if (choice == "s")
            {
                stopWatch.Start();
            }            
            Console.WriteLine("Press T to stop the watch");
            string select = Console.ReadLine();
            if (select == "t")
            {
                stopWatch.Stop();
            }
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // display the TimeSpan value.
            string elapsedTime = String.Format("{0}:{1}:{2}",ts.Hours, ts.Minutes, ts.Seconds);
            Console.WriteLine("Run Time" + elapsedTime);
        }
    }
}
