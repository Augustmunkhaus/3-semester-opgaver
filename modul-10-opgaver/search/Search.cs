namespace SearchMethods
{
    public class Search
    {
        /// <summary>
        /// Finder tallet i arrayet med en lineær søgning.
        /// </summary>
        /// <param name="array">Det array der søges i.</param>
        /// <param name="tal">Det tal der skal findes.</param>
        /// <returns></returns>
        /// 
        //opgave 1. lav en funktion der søger efter et tal i arrayet med lineær søgning
        public static int FindNumberLinear(int[] array, int tal)
        {
            // Gennemgå alle elementer i arrayet
            for (int i = 0; i < array.Length; i++)
            {
                // Tjek om det aktuelle element er lig med det søgte tal
                if (array[i] == tal)
                {
                    // Returner indekset, hvor tallet blev fundet
                    return i;
                }
            }

            // Returner -1, hvis tallet ikke blev fundet i arrayet
            return -1;
        }
        /// <summary>
        /// Finder tallet i arrayet med en binær søgning.
        /// </summary>
        /// <param name="array">Det array der søges i.</param>
        /// <param name="tal">Det tal der skal findes.</param>
        /// <returns></returns>
        /// 
        //opgave 2. lav en søgning i binær tid med samme array.
        public static int FindNumberBinary(int[] array, int tal) {
            

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if the target is at the middle of the array
                if (array[mid] == tal)
                {
                    return mid;  // Target found, return the index
                }
                // If the target is less than the middle, search in the left part
                else if (tal < array[mid])
                {
                    right = mid - 1;
                }
                // If the target is greater than the middle, search in the right part
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }

        private static int[] sortedArray { get; set; } =
            new int[] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
        private static int next = 0;

        /// <summary>
        /// Indsætter et helt array. Arrayet skal være sorteret på forhånd.
        /// </summary>
        /// <param name="sortedArray">Array der skal indsættes.</param>
        /// <param name="next">Den næste ledige plads i arrayet.</param>
        public static void InitSortedArray(int[] sortedArray, int next)
        {
            Search.sortedArray = sortedArray;
            Search.next = next;
        }

        /// <summary>
        /// Indsætter et tal i et sorteret array. En kopi af arrayet returneres.
        /// Array er fortsat sorteret efter det nye tal er indsat.
        /// </summary>
        /// <param name="tal">Tallet der skal indsættes</param>
        /// <returns>En kopi af det sorterede array med det nye tal i.</returns>
        public static int[] InsertSorted(int tal) {
            // TODO: Implement!
            
            return sortedArray;
        }
    }
}