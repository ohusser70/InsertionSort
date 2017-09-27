using System;

namespace InsertionSort
{
    public class Program
    {

        static public void Exchange (ref int v1, ref int v2)
        {
            int tmp = v1;
            v1 = v2;
            v2 = v1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ce sera un super projet de tri par insertion");
            int a = 10, b = 5;
            Console.WriteLine($"a:{a}, b:{b}");
            Exchange(ref a, ref b);
            Console.WriteLine("EXCHANGE");
            Console.WriteLine($"a:{a}, b:{b}");
            Console.ReadKey();
        }
    }
}
