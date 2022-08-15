using System;
namespace Algorithm
{
    class Program
    {
        public static void Main(String[] args)
        {
            BinarySearch bSearch = new BinarySearch();
            Console.WriteLine("Enter the element for search ");
            string word = Console.ReadLine();
            int result = bSearch.binarySearch(word);
            if (result > 5)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index " + result);

        }
    }
}