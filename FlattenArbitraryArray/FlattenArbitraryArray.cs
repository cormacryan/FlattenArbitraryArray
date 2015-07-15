using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenArbitrarilyArray
{
    public class FlattenArbitraryArray
    {
        public FlattenArbitraryArray() { }

        /// <summary>
        /// Called to flatten an arbitary nested array of integers. As an test example for the method the following
        /// array will be used.
        /// 
        /// [[1,2,[3,4]],5,6] -> [1,2,3,4,5,6]
        /// 
        /// </summary>
        /// <returns>An simple array of all integer elements flattened out.</returns>
        public static int[] FlattenArbitraryNestedArray()
        {
            // To represent a collection for a nested array of elements use a list of object's for each inner array 
            // structure of elements. The following section of code creates the array structure to hold the test 
            // case elements as specified in the comments above.

            List<object> objArray = new List<object>(3); // Represents the outer array of elements:  index 0 = [1,2,[3,4]], index 1 = 5, index 2 = 6
            objArray.Insert(0, new List<object>(3)); // Represents the inner array for index 0:  index 0 = 1, index 1 = 2, index 2 = [5,6]
            ((List<object>)objArray[0]).Insert(0, 1);
            ((List<object>)objArray[0]).Insert(1, 2);
            ((List<object>)objArray[0]).Insert(2, new List<object>(2)); // Represents the inner array for index [0,2]:  index 0 = 3, index 1 = 4
            ((List<object>)((List<object>)objArray[0])[2]).Insert(0, 3);
            ((List<object>)((List<object>)objArray[0])[2]).Insert(1, 4);
            objArray.Insert(1, 5);
            objArray.Insert(2, 6);

            List<int> outputList = new List<int>();

            // Call to traverse the list elements recursively and add each simple int value to the collection 
            RecurseObjectArray(ref outputList, objArray);

            // Return full array of elements from the List out to a simple array of ints
            return (int[])outputList.ToArray();
        }

        private static void RecurseObjectArray(ref List<int> outputList, List<object> objArray)
        {
            // Loop through each element in the list array
            for (int i = 0; i < objArray.Count; i++)
            {
                // If the array element is a simple int non object list add the element to the list
                if (objArray[i] is int)
                {
                    outputList.Add((int)objArray[i]);
                    continue;
                }
                else if (objArray[i] is List<object>)
                {
                    RecurseObjectArray(ref outputList, (List<object>)objArray[i]);
                }
            }
        }
    }
}
