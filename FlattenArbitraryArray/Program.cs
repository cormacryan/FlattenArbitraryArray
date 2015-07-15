using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenArbitrarilyArray
{
    class Program
    {
        /// <summary>
        /// Program startup to call an algorithm to flatten an arbitary array of int elements.
        /// </summary>
        static void Main(string[] args)
        {
            // [[1,2,[3,4]],5,6] -> [1,2,3,4,5,6]
            int[] flattenArray = FlattenArbitraryArray.FlattenArbitraryNestedArray();

            Console.Out.Write("[");
            for (int i = 0; i < flattenArray.Length; i++)
            {
                Console.Out.Write(flattenArray[i]);
                if (i != flattenArray.Length - 1)
                    Console.Out.Write(",");
            }
            Console.Out.Write("]");
        }
    }
}
