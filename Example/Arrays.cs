using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Arrays
    {
        public int[] ArrayA = new int[] {0, 2, 4, 6, 8, 10};
        public int[] ArrayB = new int[] {1, 3, 5, 7, 2};
        public int[] ArrayC = new int[] {3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9};

        public int[] MakeArray()
        {
            
            int input = 0;
            Console.WriteLine("Enter a number for how many integers are in your array.");
            input = int.Parse(Console.ReadLine());
            int[] cats = new int[input];

            Console.WriteLine("Fill in your desired integers.");
            for (int i = 0; i < cats.Length; i++)
            {
                cats[i] = int.Parse(Console.ReadLine());
            }
            return cats;
        }

        public double Sum(int[] array)
        {
            Console.WriteLine("Total sum of elements.");
            double total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total += array[i];
            }
            Console.WriteLine(total);
            return total;
        }

        public void Average(double counter, double sum)
        {
            double avg = sum / counter;
            Console.WriteLine($"Average is {avg}");
        }

        public void Reverse(int[] array)
        {

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }

        public int[] Rotate(Direction direction, int places, int[] array) 
        {
            int[] arrayCopy= new int[array.Length];
            if (direction == Direction.Left)
            {

                for (int i = 0; i < places; i++)
                {
                    int temp = array[0];
                    for (int j = 1; j < array.Length; j++)
                    {
                        array[j - 1] = array[j];
                    }
                    array[array.Length - 1] = temp;
                }

                return array;
            }
            else 
            {
                for (int i = 0; i < places; i++)
                {
                    int temp = array[0];
                    for (int j = 0; i < array.Length - 1; i++)
                    {
                        array[j + 1] = array[j];
                    }

                }
                return array;
            }
        }

        public void Display(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        public int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        i = 0;
                    }
                }
               

            }

            return array;
        }

        public int[] SortDesc(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    i = 0;
                }

            }

            return array;
        }

        public int[] Combine(int[] firstArray, int[] secondArray)
        {
            int[] combo = new int[firstArray.Length+secondArray.Length];
            for (int i = 0; i < firstArray.Length; i++)
            {
                combo[i] = firstArray[i];
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                combo[i + firstArray.Length] = secondArray[i];
            }
            return combo;
        }

        public enum Direction
        {
            Left = 0,
            Right =1
        }

        public int Duplicates(int[] array)
        {
            int totalNumDuplicates = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i]==array[i+1])
                {
                    int temp = array[i];
                    totalNumDuplicates += 1;
                    array[i + 1] = temp;
                }
                
            }
            return totalNumDuplicates;
        }

        public void UniqueElements(int[] array)
        {
            int unique = 0;
            int[] tempCopy = new int[array.Length];
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    unique += 1;
                }

                if (unique <= 1)
                {
                    Console.WriteLine($"{array[i]} is unique.");
                }
            }
            
        }

    }
}
