using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* QuickSort algorithm implementations
 * 
 * 
 *  Basic explanation of recursive quicksort :
 *  1. select an element from the array as the pivot
 *  2. sort the array, so that:
 *      - all elements less than the pivot, are placed before the pivot
 *      - all elements greater than the pivot, are placed after it
 *      - after this, the pivot is in it's last position - has to be returned 
 *      
 *  3. recursively repeat the steps to the sub-array of elements smaller and and the sub -array of greater elements
 *  - the base case is an array pf zero or on (by definition an array of such size is in order)
 *  
 * 1: Lomuto Quicksort, where the pivot is the last element in the array
 *      
 *      
 *      - when array is already in order, becomes O(n^2)
 * 
 * 
 * 
 * 
 * 
 * 
 */

namespace AlgorithmsAndDataStructures
{
    class QuickSortAlgorithms
    {
        internal static void LomutoQuickSort(int[] arr, int lowIndex, int hiIndex)
        {
            int pivotIndex;
            // check to see if array is not 1 or empty before proceeding
            if (lowIndex < hiIndex){
                pivotIndex = LomutoPartition(arr, lowIndex, hiIndex);
                //left (lower) subarray
                LomutoQuickSort(arr, lowIndex, pivotIndex - 1);//use dependency injection and delegateh here
                // right (higher) subarray
                LomutoQuickSort(arr, pivotIndex + 1, hiIndex );

            }
        }

        internal static int LomutoPartition(int[] arr, int lowIndex, int hiIndex)
        {
            int pivot = arr[hiIndex]; //element value at hi Index
             //start from first element of array
            int storeIndex = lowIndex;

            for (int i = lowIndex; i < hiIndex; i++)
            {
                if (arr[i] < pivot)
                {
                    Swap(arr, storeIndex, i );
                    storeIndex += 1; //++storeIndex
                }
            }
            Swap(arr, storeIndex, hiIndex);
            //sort everything to the left on the pivot (loop through all values)
            return storeIndex;
        }


        internal static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;

        }

        /*  Section below is for the original Hoare partition scheme to be implemented later 
         * 
         * 
         * 
         * 
         * 
         * 
         */


        internal static void HoareQuickSort()
        {

        }

        internal static void HoarePartition()
        {

        }


        // may not need this
        internal static void Swap()
        {

        }

        
    }
}
