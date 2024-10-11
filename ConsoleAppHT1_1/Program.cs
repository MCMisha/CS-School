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

            if (result == string.Empty)
            {
                return "0";
            }
            
            return result;
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
                uint countA = 0;
                for(char c in duodecimal)
                {
                    if (c == 'A')
                    {
                        countA++;
                    }
                }
                if (countA == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}