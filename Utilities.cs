using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

#nullable enable
namespace Calculator
{
    internal class Utilities
    {
        public int AskCLIForInt(string ToConsole)
        {
            try
            {
                Console.WriteLine(ToConsole);
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Exception in Class/Method Utilities/AskCLIForInt. Exception = {e}");
            }
            return -1;
        }
        public string AskCLIForString(string ToConsole)
        {
            try
            {
                Console.WriteLine(ToConsole);
                return Convert.ToString(Console.ReadLine());
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Exception in Class/Method Utilities/AskCLIForString. Exception = {e}");
            }
            return "";
        }
    }
}
