namespace Sortering
{
    public static class QuickSort
    {
        private static void Swap(int[] array, int k, int j)
        {
            int tmp = array[k];
            array[k] = array[j];
            array[j] = tmp;
        }

        private static void _quickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(array, low, high);
                _quickSort(array, low, pivot - 1);
                _quickSort(array, pivot + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            // Choose the rightmost element as the pivot
            int pivot = array[high];

            // Index of the smaller element
            int i = low - 1;

            // Traverse through the array and rearrange elements
            for (int j = low; j < high; j++)
            {
                // If current element is smaller than or equal to the pivot
                if (array[j] <= pivot)
                {
                    i++;

                    // Swap array[i] and array[j]
                    Swap(array, i, j);
                }
            }

            // Swap array[i+1] and array[high] (put the pivot in its correct position)
            Swap(array, i + 1, high);

            // Return the index of the pivot element
            return i + 1;
        }

        public static void Sort(int[] array)
        {
            _quickSort(array, 0, array.Length - 1);
        }
    }
}
