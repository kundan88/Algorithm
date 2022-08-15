using System;
namespace Algorithm;

    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = { 10, 1, 23, 50, 4, 9, -4 };
            int n = MyArray.Length;
            Console.Write("Original Array\n");
            MergeSort ms = new MergeSort();
            ms.PrintArray(MyArray);

            ms.mergesort(MyArray, 0, n - 1);
            Console.Write("\nSorted Array\n");
            ms.PrintArray(MyArray);
        }
    }

