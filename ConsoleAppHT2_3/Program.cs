using System;

namespace ConsoleAppHT2_3 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var training = new Training();
            
            training.Add(new Lecture("Introduction to Java", "Java Basics"));
            training.Add(new PracticalLesson("Practice simple types",
                "https://task.pl/simple-types", "https://solution.com/simple-types"));
            training.Add(new PracticalLesson("Practice conditionals",
                "https://task.pl/conditionals", "https://solution.com/conditionals"));
            
            Console.WriteLine("Original Training:");
            training.PrintTraining();
            
            Console.WriteLine($"Is the training practical only? {training.IsPractical()}");
            
            var clonedTraining = training.Clone();
            
            Console.WriteLine("\nCloned Training:");
            clonedTraining.PrintTraining();
        }
    }
}