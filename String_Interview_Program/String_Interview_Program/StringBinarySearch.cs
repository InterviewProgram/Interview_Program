using System;
namespace String_Interview_Program
{
    public class StringBinarySearch
    {
        // Get the binary search on string  
        public void BinarySearchOnstring()
        {
            string[] arr = new string[] { "Hi", "Guest", "I", "Interview", "Am" };
            Array.Sort(arr); // Am, Guest, Hi, I, Mukesh  
            var index = Array.BinarySearch<string>(arr, "Hi");

            Console.WriteLine("The position of 'Hi' in array is " + index);
        }
    }

}
