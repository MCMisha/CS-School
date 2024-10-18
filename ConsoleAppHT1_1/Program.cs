using System.Diagnostics.CodeAnalysis;

namespace ConsoleAppHT1_1 
{
    internal class Program
    {
        private const string digits = "0123456789AB";
        static string ConvertIntToDuodecimal(int intNumber)
        {
            if (intNumber == 0)
            {
                return "0";
            }

            bool isNegative = intNumber < 0;
            intNumber = Math.Abs(intNumber);
            string result = string.Empty;
            
            while (intNumber > 0)
            {
                result = digits[intNumber % 12] + result;
                intNumber /= 12;
            }

            if (result == string.Empty)
            {
                return "0";
            }
            
            return isNegative ? "-" + result : result;
        }
        
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two integers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (b < a)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            for (int i = a; i <= b; i++)
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