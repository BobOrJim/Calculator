using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Calculator
{
    internal class Assignment1
    {
        #nullable enable
        private Utilities Utils = new Utilities();
        public async Task Run()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            while (true)
            {
                Console.WriteLine();
                switch (Utils.AskCLIForInt("Select an Integer calculator. 0=Exit, 1=Addition, 2=Subtraction, 3=Division, 4=Multiplication"))
                {
                    case 0:
                        Exit();
                        break;
                    case 1:
                        Addition();
                        break;
                    case 2:
                        Subtraction();
                        break;
                    case 3:
                        Division();
                        break;
                    case 4:
                        Multiplication();
                        break;
                    default:
                        Console.WriteLine("Invalid selection, try again");
                        break;
                }
            }
        }

        private void Exit()
        {
            System.Environment.Exit(1);
        }

        private void Addition()
        {
            try
            {
                string[] Words = Utils.AskCLIForString("Enter a string for Addition Ex 1+2+3+4+5 ").Split("+");
                int[] Ints = Array.ConvertAll(Words, s => int.Parse(s));
                Console.WriteLine($"Resultat: {Ints.Sum()}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid string, please try again");
                Debug.WriteLine($"Exception in Class/Method Assignment1/Addition. Exception = {e}");
            }
        }

        private void Subtraction()
        {
            try
            {
                string[] Words = Utils.AskCLIForString("Enter a string for Subtraction Ex 1-2-3-4-5 ").Split("-");
                int[] Ints = Array.ConvertAll(Words, s => int.Parse(s));
                Console.WriteLine($"Resultat: {Ints[0] - Ints.Sum() + Ints[0]}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid string, please try again");
                Debug.WriteLine($"Exception in Class/Method Assignment1/Subtraction. Exception = {e}");
            }
        }

        private void Division()
        {
            try
            {
                string[] Words = Utils.AskCLIForString("Enter a string with 2 numbers for Division Ex 2/10 ").Split("/");
                int[] Ints = Array.ConvertAll(Words, s => int.Parse(s));
                Console.WriteLine($"Resultat: {(Decimal)Ints[0] / (Decimal)Ints[1]}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid string, please try again");
                Debug.WriteLine($"Exception in Class/Method Assignment1/Division. Exception = {e}");
            }
        }

        private void Multiplication()
        {
            try
            {
                string[] Words = Utils.AskCLIForString("Enter a string with 2 numbers for Multiplication Ex 2*10 ").Split("*");
                int[] Ints = Array.ConvertAll(Words, s => int.Parse(s));
                Console.WriteLine($"Resultat: {Ints[0] * Ints[1]}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid string, please try again");
                Debug.WriteLine($"Exception in Class/Method Assignment1/Multiplication. Exception = {e}");
            }
        }
    }
}
