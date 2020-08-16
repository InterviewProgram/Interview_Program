using System;
using System.Collections.Generic;
using System.Text;

namespace String_Interview_Programm
{
    public class ReverseEachWord
    {
        // Reverse each word of the sentence  
        public string ReverseEachString(string str)
        {
            string result = "";
            if (string.IsNullOrEmpty(str))
                return string.Empty;

            string[] arr = str.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {
                    result += ReverseString(arr[i]) + " ";
                }
                else
                {
                    result += ReverseString(arr[i]) + " ";
                }
            }
            return result;
        }
        public string ReverseString(string str)
        {
            string result = "";

            if (string.IsNullOrEmpty(str))
                return string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }

            return result;
        }
    }

}
