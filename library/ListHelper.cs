using System;
using System.Collections.Generic;  

namespace library
{
    public static class ListHelper
    {

        ///<summary>
        /// A generic extension function that perform Swapping of 2 element of List of Object
        ///</summary>
        /// <remarks>
        /// invalid index or list with < 2 element will not be swap 
        /// </remarks>
        /// <example>
        /// <code>
        /// List&ltdouble&gt listOfDouble=  List&ltdouble&gt{ 1.2, 1.3, 1.4, 1.5 };
        /// listOfDouble.Swap(0,1);
        /// Console.WriteLine(listOfDouble[0]);
        /// Console.WriteLine(listOfDouble[1]);
        /// </code>
        /// </example>     
        public static void Swap<T>( this List<T> list,int i, int j){
            if(list.Count > 1 && i != j && i >= 0 && i < list.Count && j >= 0 && j < list.Count){
                T temp;
                temp = list[i];
                list[i]  = list[j];
                list[j] = temp;
            }
            
        }

        ///<summary>
        /// A generic extension function that print all the content of list
        ///</summary>
        /// <remarks>
        /// content of each object in list will be print using the result of toString() function
        /// </remarks> 
        /// <example>
        /// <code>
        /// List&ltdouble&gt listOfDouble=  List&ltdouble&gt{ 1.2, 1.3, 1.4, 1.5 };
        /// listOfDouble.printList();
        /// </code>
        /// </example>  
        public static void printList<T>(this List<T> list){
            for(int i = 0; i < list.Count; i++){
                Console.WriteLine(list[i].ToString());
            }
            Console.WriteLine("=======================================================");
        }

    }
}