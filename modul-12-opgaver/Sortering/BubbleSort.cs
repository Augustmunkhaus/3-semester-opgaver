using System.Linq;
using System.Collections.Generic;
namespace Sortering
{
    public class BubbleSort
    {
        // Method to swap two elements in an array
        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i]; // Temporary variable to hold the value of the element at index i
            array[i] = array[j]; // Assign the value of the element at index j to the element at index i
            array[j] = temp;  // Assign the value stored in the temporary variable to the element at index j
        }
        // Method to perform bubble sort on an array
        public static void Sort(int[] array)
        {     // Outer loop to iterate through each element in the array
            for (int i = array.Length - 1; i >= 0; i--)
            {  // Inner loop to compare and swap adjacent elements
                for (int j = 0; j <= i - 1; j++)
                {     // If the current element is greater than the next element, swap them
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
        }
    }
}
