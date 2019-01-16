using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1._1
{
    class Program
    { 

        static void Main(string[] args)
        {

            //Console.WriteLine("Parallel invoke, chose 1");


            //int input;
            

            //input = Console.Read();

            //Console.WriteLine(input);


            //Console.ReadLine();

            Listning_1();

        }

        private static void Listning_1()
        {
            Parallel.Invoke(() => Task1(), () => Task2(), () => Task3());
            Console.WriteLine("Finished");
            Console.ReadKey();
        }

        static void Task1()
        {
            Console.WriteLine("Task1 starting");
            Thread.Sleep(2000);
            Console.WriteLine("Task 1 ending");
        }

        static void Task2()
        {
            Console.WriteLine("Task2 starting");
            Thread.Sleep(1000);
            Console.WriteLine("Task2 ending");
        }

        static void Task3()
        {
            Console.WriteLine("Task3 starting");
            Thread.Sleep(3000);
            Console.WriteLine("Task3 ending");
        }

    }
}
