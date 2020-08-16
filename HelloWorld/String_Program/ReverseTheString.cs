using System;
using System.Collections.Generic;
using System.Text;

namespace String_Interview_Programm
{
    public class ReverseTheString
    {
        // Reverse the single string  
        public string ReverseString(string _title)
        {
            string result = "";

            if (string.IsNullOrEmpty(_title))
                return string.Empty;

            for (int i = _title.Length - 1; i >= 0; i--)
            {
                result += _title[i];
            }

            return result;
        }
    }

}
