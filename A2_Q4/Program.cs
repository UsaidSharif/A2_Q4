using System;
using System.Linq;

namespace A2_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Number of elements to be entered in an array!");
            int Number = Convert.ToInt32(Console.ReadLine());

            int[] terms = new int[Number];

            for (int i = 0; i < Number; i++)
            {
                Console.WriteLine("Write elements to be entered in an array!");
                int value = Convert.ToInt32(Console.ReadLine());
                terms[i] = value;
            }

            Console.WriteLine("Array you made is\n ");

            for (int m = 0; m < Number; m++)
            {
                Console.Write(" " + terms[m]+"\n");
            }
            Console.WriteLine("New Array after removing duplicates is\n ");
            int[] distinct = terms.Distinct().ToArray();
            Console.WriteLine(String.Join(" ", distinct));

            
        }
    }
}
