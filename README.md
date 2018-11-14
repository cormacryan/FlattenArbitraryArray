# FlattenArbitraryArray
Algorithm to flatten an arbitary array of int elements.

This algorithm is called to flatten an arbitary nested array of integers into a simple array of integers.

In the following nested array example the output produced should contain the simple array elements flattened out.

e.g. [[1,2,[3,4]],5,6] -> [1,2,3,4,5,6]

This algorithm uses the List structure to store each input list array element grouped and recursion to iterate over
each element checking if it contains a simple int or a further deeper array to pass to the recursive method until all
elements have been checked.
