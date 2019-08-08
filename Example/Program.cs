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

            //int[] array = arrays.MakeArray();
            //int[] array1 = arrays.MakeArray();

            //int[] combinedArray = arrays.Combine(array, array1);
            //arrays.SortDesc(combinedArray);
            //Console.WriteLine("Combined and assorted array: ");
            //arrays.Display(combinedArray);

            //double sum = arrays.Sum(array);
            //arrays.Average(array.Length, sum);

            //arrays.Reverse(array);

            //int[] arrayA = arrays.Rotate(Arrays.Direction.Left, 2, arrays.ArrayA);
            //int[] arrayB = arrays.Rotate(Arrays.Direction.Right, 2, arrays.ArrayB);
            //int[] arrayC = arrays.Rotate(Arrays.Direction.Left, 4, arrays.ArrayC);

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
            Console.WriteLine("ArrayA reversed:");
            arrays.Reverse(arrayA);
            Console.WriteLine("ArrayB reversed:");
            arrays.Reverse(arrayB);
            Console.WriteLine("ArrayC reversed:");
            arrays.Reverse(arrayC);

            int[] rotatedArrayA=arrays.Rotate(Arrays.Direction.Left, 2, arrayA);
            int[] rotatedArrayB = arrays.Rotate(Arrays.Direction.Right, 2, arrayB);
            int[] rotatedArrayC = arrays.Rotate(Arrays.Direction.Left, 4, arrayC);
            Console.WriteLine("Rotated arrayA left by two places: ");
            arrays.Display(rotatedArrayA);
            Console.WriteLine("Rotated arrayB right by two places: ");
            arrays.Display(rotatedArrayB);
            Console.WriteLine("Rotated arrayC left by four places");
            arrays.Display(rotatedArrayC);

            Console.WriteLine("CHANGED");


            //int[] arrangedArray = arrays.Sort(arrays.ArrayC);
            //arrays.Display(arrangedArray);
            //int numberOfDuplicates = arrays.Duplicates(arrangedArray);
            //Console.WriteLine($"Number of duplicates is {numberOfDuplicates}");

            //arrays.UniqueElements(array);



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
