using System;
using System.Collections.Generic;
using System.Text;

namespace String_Interview_Programm
{
    public class CheckStringPalindrome
    {
        // Check the string is a palindrome  
        public bool CheckPalindrome(string str)
        {
            bool result = true;

            if (string.IsNullOrEmpty(str))
                return false;

            str = str.ToLower().Trim();

            var min = 0;
            var max = str.Length - 1;

            while (max >= 0)
            {
                if (str[min] == str[max])
                {
                    min++;
                    max--;
                }
                else
                {
                    return false;
                }
            }

            return result;
        }
    }

}
