using System;
using System.Collections.Generic;  

namespace library
{
    ///<summary>
    /// Class for performing Sort 
    ///</summary>
    public static class ListQuickSort
    {
        ///<summary>
        /// Public extension method for Sorting Generic List of Object which extend IComparable
        ///</summary>
        /// <remarks>
        /// Implement QuickSort Function 
        /// </remarks>
        /// <returns>
        /// This Function perform sort inplace and return void
        /// </returns>
        /// <example>
        /// <code>
        /// List&ltdouble&gt listOfDouble=  List&ltdouble&gt{ 1.2, 1.3, 1.4, 1.5 };
        /// listOfDouble.PerformSort();
        /// for(int i = 0; i < listOfDouble.Count; i ++){
        ///     Console.Write(listOfDouble[i]);
        ///     Console.Write(" ")        
        ///}
        /// </code>
        /// </example>
        public static void PerformSort<T>(this List<T> list) where T : IComparable<T>
        {
            QuickSort(list,0,list.Count-1);
        }
        
        ///<summary>
        /// Quick Sort function 
        ///</summary>
        /// <remarks>
        /// Private function 
        /// </remarks>
        /// <example>
        /// <code>
        /// List&ltdouble&gt listOfDouble=  List&ltdouble&gt{ 1.2, 1.3, 1.4, 1.5 };
        /// QuickSort(listOfDouble, 0, listOfDouble.Count-1);
        /// for(int i = 0; i < listOfDouble.Count; i ++){
        ///     Console.Write(listOfDouble[i]);
        ///     Console.Write(" ")        
        ///}
        /// </code>
        /// </example>
        private static void QuickSort<T>(List<T> list, int start, int end) where T : IComparable<T>
        {
            if(start < end){
                int pivotIndex = Partition(list,start,end);
                QuickSort(list,start,pivotIndex-1);
                QuickSort(list,pivotIndex+1,end);
            }
        }

        ///<summary>
        /// Partition Function for QuickSort
        ///</summary>
        /// <remarks>
        /// Private function 
        /// </remarks>
        /// <returns>
        /// return an interger indicate the position of the Pivot in QuickSort
        /// </returns>
        /// <example>
        /// <code>
        /// List&ltdouble&gt listOfDouble=  List&ltdouble&gt{ 1.2, 1.3, 1.4, 1.5 };
        /// Partition(listOfDouble, 0, listOfDouble.Count-1);
        /// for(int i = 0; i < listOfDouble.Count; i ++){
        ///     Console.Write(listOfDouble[i]);
        ///     Console.Write(" ")        
        ///}
        /// </code>
        /// </example>
        
        private static int Partition<T>(List<T> list, int start, int end) where T : IComparable<T>
        {
            T pivot = list[end];
            int i = start - 1;
            for(int j = start; j < end; j++){
                if(list[j].CompareTo(pivot) < 0){
                    i++;
                    list.Swap(i,j);
                }
            }
            list.Swap(i+1,end);
            return (i+1);
        }
    }
}