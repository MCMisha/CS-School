using System.Diagnostics.CodeAnalysis;

namespace ConsoleAppHW1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static string ConvertIntToDuodecimal(int intNumber)
        {
            string result = string.Empty;
            const string digits = "0123456789AB";
            
            while (intNumber > 0)
            {
                result = digits[intNumber % 12] + result;
                intNumber /= 12;
            }

            return result == string.Empty ? "0" : result;
        }
        
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two integers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i < b + 1; i++)
            {
                string duodecimal = ConvertIntToDuodecimal(i);
                if (duodecimal.Count(ch => ch == 'A') == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}