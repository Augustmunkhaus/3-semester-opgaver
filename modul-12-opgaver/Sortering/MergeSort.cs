namespace Sortering
{
    public static class MergeSort
    {
        public static void Sort(int[] array)
        {
            _mergeSort(array, 0, array.Length - 1);
        }

        private static void _mergeSort(int[] array, int l, int h)
        {
            if (l < h)
            {
                int m = (l + h) / 2;
                _mergeSort(array, l, m);
                _mergeSort(array, m + 1, h);
                Merge(array, l, m, h);
            }
        }

        private static void Merge(int[] array, int low, int middle, int high)
        {
            // Calculate the sizes of the two subarrays to be merged
            int n1 = middle - low + 1;
            int n2 = high - middle;

            // Create temporary arrays to hold the values of the two subarrays
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            // Copy data to temporary arrays leftArray[] and rightArray[]
            for (int i = 0; i < n1; ++i)
                leftArray[i] = array[low + i];
            for (int j = 0; j < n2; ++j)
                rightArray[j] = array[middle + 1 + j];

            // Merge the two temporary arrays back into the original array

            // Initial indexes of the two subarrays and the merged array
            int indexLeft = 0, indexRight = 0, indexMerged = low;

            // Compare elements from the two subarrays and merge them in sorted order
            while (indexLeft < n1 && indexRight < n2)
            {
                if (leftArray[indexLeft] <= rightArray[indexRight])
                {
                    array[indexMerged] = leftArray[indexLeft];
                    indexLeft++;
                }
                else
                {
                    array[indexMerged] = rightArray[indexRight];
                    indexRight++;
                }
                indexMerged++;
            }

            // Copy the remaining elements of leftArray[], if any
            while (indexLeft < n1)
            {
                array[indexMerged] = leftArray[indexLeft];
                indexLeft++;
                indexMerged++;
            }

            // Copy the remaining elements of rightArray[], if any
            while (indexRight < n2)
            {
                array[indexMerged] = rightArray[indexRight];
                indexRight++;
                indexMerged++;
            }
        }
    }
}


