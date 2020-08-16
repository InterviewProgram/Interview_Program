using System;
using System.Collections.Generic;
using System.Text;

namespace String_Interview_Programm
{
    public class CheckMaxOccuranceCharater
    {
        // Check the max occurance of the any character in the string  
        public char? CheckMaxOccuranceOfChar(string str)
        {
            char? maxOccuranceChar = null;
            int maxOccuranceValue = 0;

            if (string.IsNullOrEmpty(str))
                return null;

            str = str.ToLower().Trim();
            char[] arr = str.ToCharArray();

            Dictionary<char, int> _dictionary = new Dictionary<char, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != ' ')
                {
                    if (!_dictionary.ContainsKey(arr[i]))
                    {
                        _dictionary.Add(arr[i], 1);
                    }
                    else
                    {
                        _dictionary[arr[i]]++;
                    }
                }
            }


            foreach (KeyValuePair<char, int> item in _dictionary)
            {
                if (item.Value > maxOccuranceValue)
                {
                    maxOccuranceChar = item.Key;
                    maxOccuranceValue = item.Value;
                }
            }

            return maxOccuranceChar;
        }
    }

}
