using System;

namespace Array_noten
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int[] Noten = new int[n];
            int summe = 0;

            for (int index = 0; index < n; index++)
            {
                Console.WriteLine(index);
                Noten[index] = Convert.ToInt32(Console.ReadLine());
                summe = summe + Noten[index];
            }

            Console.WriteLine(summe / n);


            foreach (int s in Noten)
                Console.WriteLine(s);

            Console.ReadLine();
        }
    }
}
