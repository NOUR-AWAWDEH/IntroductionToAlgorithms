using System;

namespace ConsoleApp1
{
    public class InseartionSortAlgorithm
    {
        static void Main(string[] args)
        {
            int[] arr = { 123,23,4,43543,56,45,7,567,56,8,5,667,34,52,345,23,42,34,1 };

            InseartionSort(arr);
            Console.WriteLine("The Sorted Array: \n");
            foreach(int num in arr)
            {
                Console.Write(num);
                Console.Write(", ");
            }
            Console.WriteLine("\n");
            Console.ReadLine();  
        }
       
        public static void InseartionSort(int[] arr) 
        {
            int arrayLength = arr.Length;

            for (int currentIndex = 1 ; currentIndex < arrayLength ; ++currentIndex) 
            {
                int key = arr[currentIndex];
                int sortedIndex = currentIndex - 1;

                while (sortedIndex >= 0 && arr[sortedIndex] > key) 
                {
                    arr[sortedIndex + 1] = arr[sortedIndex];
                    sortedIndex= sortedIndex -1;
                }
                arr[sortedIndex + 1] = key;
            }
        }
    }
}
