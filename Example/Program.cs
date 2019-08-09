using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays arrays = new Arrays();

            //Counting, Summing, computing mean
            int[] arrayA = arrays.ArrayA;
            int[] arrayB = arrays.ArrayB;
            int[] arrayC = arrays.ArrayC;
            double sumA = arrays.Sum(arrayA);
            double sumB = arrays.Sum(arrayB);
            double sumC = arrays.Sum(arrayC);
            Console.WriteLine("");
            arrays.Average(arrayA.Length, sumA);
            arrays.Average(arrayB.Length, sumB);
            arrays.Average(arrayC.Length, sumC);

            Console.WriteLine("");

            //Reversing arrays
            Console.WriteLine("\nArrayA reversed:");
            arrays.Reverse(arrayA);
            Console.WriteLine("\nArrayB reversed:");
            arrays.Reverse(arrayB);
            Console.WriteLine("\nArrayC reversed:");
            arrays.Reverse(arrayC);
            Console.WriteLine("");

            //Rotating arrays
            int[] rotatedArrayA=arrays.Rotate(Arrays.Direction.Left, 2, arrayA);
            int[] rotatedArrayB = arrays.Rotate(Arrays.Direction.Right, 2, arrayB);
            int[] rotatedArrayC = arrays.Rotate(Arrays.Direction.Left, 4, arrayC);
            Console.WriteLine("\nRotated arrayA left by two places: ");
            arrays.Display(rotatedArrayA);
            Console.WriteLine("\nRotated arrayB right by two places: ");
            arrays.Display(rotatedArrayB);
            Console.WriteLine("\nRotated arrayC left by four places");
            arrays.Display(rotatedArrayC);

            //Sorting arrays
            int[] sortedArray =arrays.Sort(arrayC);
            Console.WriteLine("\n\nSorted array:");
            arrays.Display(sortedArray);

            //Deep copy of array
            //int[] cats2 = new int[cats.Length];
            //for (int i = 0; i < cats.Length; i++)
            //{
            //    cats2[i] = cats[i];
            //}
            //Console.WriteLine("First array printed:");
            //for (int i = 0; i < cats.Length; i++)
            //{
            //    Console.WriteLine(cats[i]);
            //}
            //Console.WriteLine("Second array printed:");
            //for (int i = 0; i < cats2.Length; i++)
            //{
            //    Console.WriteLine(cats2[i]);
            //}

        }


    }
}
