using static System.Array;
using System.Collections;

namespace UsingArray
{
    internal class UsingArray
    {
        private static int[] intValues = { 1, 2, 3, 4, 5, 6 };
        private static double[] doubleValues = { 8.4, 9.3, 0.2, 7.9, 3.4 };
        private static int[] intValuesCopy;


        static void Main()
        {
            intValuesCopy = new int[intValues.Length];  // Defaults to zeroes

            Console.WriteLine("Initial array values:\n");
            PrintArrays(); // Output initial array contents

            // Sort doubleValues
            Sort(doubleValues); // Unqualified call to Array static method Sort

            // Copy intValues into intValuesCopy
            Array.Copy(intValues, intValuesCopy, intValues.Length);

            Console.WriteLine("\nArray values after SOrt and Copy:\n");
            PrintArrays(); // Output array contents
            Console.WriteLine();

            // Search for 5 in intValues
            int result = Array.BinarySearch(intValues, 5);
            Console.WriteLine(result >= 0 ?
                $"5 found at element {result} in intValues" :
                "5 not found in intValues");

            // Search for 8763 in intValues
            result = Array.BinarySearch(intValues, 8763);
            Console.WriteLine(result >= 0 ?
                $"8763 found at element {result} in intValues" :
                "8763 not found in intValues");
        }

        // Output array contents with enumerators 
        private static void PrintArrays()
        {
            Console.Write("doubleValues: ");

            // Iterate through the double array with an enumerator
            IEnumerator enumerator = doubleValues.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.Write($"{enumerator.Current} ");
            }

            Console.Write("\nintValues: ");

            // Iterate through the int array with an enumerator
            enumerator = intValues.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.Write($"{enumerator.Current} ");
            }

            Console.Write("\nintValuesCopy: ");

            // Iterate through the second int array with a foreach statement
            foreach (var element in intValuesCopy)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
    }
}