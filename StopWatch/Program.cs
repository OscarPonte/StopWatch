using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var stopWatch = new StopWatch();

                Console.Write("Press Enter to START the StopWatch!");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                    break;

                Console.WriteLine(stopWatch.Start());


                Console.Write("Press Enter to STOP the StopWatch!!");
                var input1 = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input1))
                    break;

                Console.WriteLine(stopWatch.Stop());
                Console.WriteLine(stopWatch.Duration() + " Seconds");

                Console.Write("To Try one more time press ENTER");
                var input2 = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input2))
                    break;
            }
        }
    }
}
