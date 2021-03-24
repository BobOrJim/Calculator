using System;
using System.Threading;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment1 App = new Assignment1();
            App.Run(); //This is a Task. If we want to do someting fun below, we are free to do so :)

            int counter = 0;
            while (true)
            {
                Thread.Sleep(1000);
                counter += 1;
                //Console.WriteLine($"Hanging around in Main()...waiting for someting fun... {counter}");
            }
        }
    }
}



