using System.Diagnostics.CodeAnalysis;

namespace ConsoleAppHT1_2
{
    internal class Program
    {
        static string CalculateControlNumberIsbn(string isbn)
        {
            int sum = 0;
            
            for (int i = 0; i < isbn.Length; i++)
            {
                sum += int.Parse(isbn[i].ToString()) * (10 - i);
            }
            
            int controlNumber = (11 - (sum % 11)) % 11;
            string checkDigit = controlNumber == 10 ? "X" : controlNumber.ToString();
            return isbn + checkDigit;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ISBN: ");
            string isbn = Console.ReadLine();
            string isbnWithControlNumber = CalculateControlNumberIsbn(isbn);
            Console.WriteLine("Control number: " + isbnWithControlNumber);
        }
    }
}