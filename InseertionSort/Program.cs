using System;

namespace InsertionSort
{
    public class Program
    {

        /// <summary>
        /// xchange method that is not used, because insertion sort shifts values
        /// and does not swap them
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        static public void Exchange (ref int v1, ref int v2)
        {
            int tmp = v1;
            v1 = v2;
            v2 = tmp;
        }

        static public void InsertSort(int[] tab, int G, int D)
        {
            for (int i= G+1; i<=D;i++)  //insert elements one by one
            {
                int save = tab[i];
                int j = i - 1;
                while ((j>=G) && (tab[j]>save) )    // && ne fait le second test que si le premier passe!
                {
                    tab[j + 1] = tab[j];
                    j--;
                }
                // we do insert the value now
                tab[j+1] = save;
            }
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
            Console.WriteLine("LE TRI LE TRI LE TRI ...");
            int[] values = new int[16];
            Random rnd = new Random();
            for (int i = 0; i < 16; i++)
            {
                values[i] = rnd.Next(0, 1000);
                Console.Write($"{values[i]}, ");
            }
            InsertSort(values, 0, 15);
            Console.WriteLine("\n\n");
            for (int i = 0; i < 16; i++)
            {
                Console.Write($"{values[i]}, ");
            }

            Console.ReadKey();
        }
    }
}
