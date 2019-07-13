using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures {
    class MergeSortAlgorithms {
        // ! COULD PROBABLY USE SOME SORT OF DEPENDENCY INJECTION TO CHOOSE WHICH METHOD OF MERGIN TO BE USED!!!! -- WILL DO THIS LATER
        // requires a merging function to be used once base case is reached - which is recursively split until the array is 1
        internal static void MergeSort(int[] arrayToSort, int leftIndex, int rightIndex) {
            // specify whether the array is bigger than 1 in size (when index is different)
            if (leftIndex < rightIndex) {
                //split into half and recursively call (which loops) until base case is met
                int middleIndex = leftIndex + (rightIndex - leftIndex)/2; //automatically truncates, avoid overflow
                MergeSort(arrayToSort, leftIndex, middleIndex);
                MergeSort(arrayToSort, middleIndex + 1, rightIndex);
                Merge(arrayToSort, leftIndex, middleIndex, rightIndex) ;

                // after recursion stops due to array being single membered, recursion tree backtracks and exits next statement
            }
            
        }


        // uses pass by reference to ensure no extra memory is used???
        internal static void Merge(int[] arrayToSort, int leftStart, int middle, int rightEnd) {
            
            int leftLength = (middle - leftStart) + 1; //add one for length
            int rightLength = (rightEnd - middle);
            
            //arrays for temporary copying from
            int[] leftArray = new int[leftLength]; //create an array of the same size
            int[] rightArray = new int[rightLength];
            
            // copy values to temporary arrays
            for (int i = 0; i < leftLength; i++) {
                leftArray[i] = arrayToSort[leftStart + i];
            }
            for (int i = 0; i < rightLength; i++) {
                rightArray[i] = arrayToSort[middle + 1 + i];
            }

            //int leftIndex = 0;
            //int rightIndex = 0;
            int leftIndex = 0, rightIndex = 0;
            int sortIndex = leftStart;
            while (leftIndex < leftLength && rightIndex < rightLength) {
                if (leftArray[leftIndex] < rightArray[rightIndex]) {
                    arrayToSort[sortIndex] = leftArray[leftIndex];
                    leftIndex = leftIndex + 1;
                } else {
                    arrayToSort[sortIndex] = rightArray[rightIndex];
                    rightIndex = rightIndex + 1;
                }
                sortIndex = sortIndex + 1;
            }
           
            // below checks if any remaining elements are left in each portion, and adds them to the merged array
            while (leftIndex < leftLength) {
                //Debug.WriteLine("[{0}]", string.Join(", ", tempArray));
                arrayToSort[sortIndex] = leftArray[leftIndex];
                sortIndex = sortIndex + 1;
                leftIndex = leftIndex + 1;
            }

            while (rightIndex < rightLength) {
                arrayToSort[sortIndex] = rightArray[rightIndex];
                sortIndex = sortIndex + 1;
                rightIndex = rightIndex + 1;
            }


            
        }

        
    }
}
