using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace removeDuplicates
{
    public class Program
    {
        public static void Main()
        {
            // Declare an array of integer type
            int[] data = { 10, 20, 30, 40, 40, 50, 50, 50, 60, 60 };
            Console.WriteLine("Array before removing duplicate values: ");
            Array.ForEach(data, i => Console.WriteLine(i));

            // Use distinct() function
            // To create an array that contain distinct values
            int[] unique = data.Distinct().ToArray();

            // Display the final result
            Console.WriteLine("Array after removing duplicate values: ");
            Array.ForEach(unique, j => Console.WriteLine(j));
        }
    }
}
