using System;
using System.Diagnostics;

/* C# Implementation of RECURSIVE binary Search
 * is static as we don't need multiple objects of this
 * 
 * 
 * if value is less than  middle interval, narrow the interval to lower half, otherwise upper half
 * repeatedly check until the VALUE IS FOUND OR INTERVAL IS EMPTY
 * 
 * 
 * base case = interval is empty or value equal
 */


//  This accepts an ARRAY of INTEGERS and fins the specified value
//  xVal : value that is to be found from the array
// default for left and right values should be: 
// left: 0 (first index)
// 
namespace AlgorithmsAndDataStructures {
    class SearchAlgorithms {

        static int BinarySearchRecursive(int[] array, int xVal, int left, int right){

            //one base case is when empty
            if (left > right) {
                return -1;

            }
            // remove intehe roverflow
            int midIndex = left + (right - left) / 2; // note that this rounds upwards as INT
            // second base condition(xVal is found)
            if (xVal == array[midIndex]) {
                return array[midIndex];

            }
            if (xVal < array[midIndex]) {
                return BinarySearchRecursive(array, xVal, left, midIndex - 1); // midIndex-1 becomes upper bound, (minus 1 because this item has been compared already)
            } else {
                return BinarySearchRecursive(array, xVal, midIndex + 1 , right);
            }
           
        }
        public static void Main() {
            int[] array = { 2,3,4,10,40};
            int arrLen = array.Length;
            int findVal = 10;

            int result = BinarySearchRecursive(array, findVal, 0, arrLen - 1);

            if (result == -1){
                Console.WriteLine("Element not found");
                Debug.WriteLine("Element not found");

            } else {
                Console.WriteLine("Element found at index " + result);
                Debug.WriteLine("Element found at index " + result);
            }


            int[] arrayToMergeSort = {10, 12, 6, 3, 4, 9, 5, 3, 2, 2, 34, 6, 8, 45};
            int size = arrayToMergeSort.Length;
            
            MergeSortAlgorithms.MergeSort(arrayToMergeSort, 0, size - 1);

            Debug.WriteLine(arrayToMergeSort);

            Debug.WriteLine("[{0}]", string.Join(", ", arrayToMergeSort));
        }
    }
}



