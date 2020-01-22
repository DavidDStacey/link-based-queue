using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Link_Based_Queue
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //new queue
            Queue thisQueue = new Queue();
            // calss options
            options();
            // used when testing -- not needed/ unused now
            ReadKey();
            //options for new queue -- recursive 
            void options()
            {
                WriteLine("What would you like to do? " +
                    "\nEnter 1 for enqueue " +
                    "\nEnter 2 for dequeue " +
                    "\nEnter 3 to display queue " +
                    "\nEnter 4 to peek " +
                    "\nEnter 5 to exit\n");
                string key = ReadLine();
                if (key == "1")
                {
                    WriteLine("\nWhat would you like to enqueue?\n");
                    int temp = Convert.ToInt32(ReadLine());
                    thisQueue.Enqueue(temp);
                }
                else if (key == "2")
                {                 
                    thisQueue.Dequeue();
                }
                else if (key == "3")
                {
                    thisQueue.PrintQueue();
                }
                else if (key == "4")
                {
                    thisQueue.Peek();
                }
                else if (key == "5")
                {
                    WriteLine("\nPress any key to exit.");
                    ReadKey();
                    Environment.Exit(0);
                }
                else
                {
                    WriteLine("\nSorry incorrect input");
                }
                options();
            }
        }
    }
}
