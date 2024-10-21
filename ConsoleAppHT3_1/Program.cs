namespace ConsoleAppHT3_1
{
    internal class Program
    {
        static void Main()
        {
            IQueue<int> queueWithInt = new Queue<int>();
            IQueue<(uint, uint)> queueWithPairsOfUint = new Queue<(uint, uint)>();
            IQueue<double> queueWithDouble = new Queue<double>();
            
            queueWithInt.Enqueue(10);
            queueWithInt.Enqueue(20);
            queueWithInt.Enqueue(30);
            
            queueWithPairsOfUint.Enqueue((10, 20));
            queueWithPairsOfUint.Enqueue((30, 40));
            queueWithPairsOfUint.Enqueue((50, 60));

            queueWithDouble.Enqueue(10.2);
            queueWithDouble.Enqueue(20.4);
            queueWithDouble.Enqueue(30.6);
            IQueue<double> tail = queueWithDouble.Tail();
            
            Console.WriteLine("Queue with integers:");
            while (!queueWithInt.IsEmpty())
            {
                Console.Write($"{queueWithInt.Dequeue()} ");
            }
            Console.WriteLine();
            
            Console.WriteLine("Queue with pairs of unsigned integers:");
            while (!queueWithPairsOfUint.IsEmpty())
            {
                (uint first, uint second) = queueWithPairsOfUint.Dequeue();
                Console.Write($"({first}, {second}) ");
            }
            Console.WriteLine();
            
            Console.WriteLine("Queue with doubles(tail):");
            while (!tail.IsEmpty())
            {
                Console.Write($"{tail.Dequeue()} ");
            }
        }
    }
}