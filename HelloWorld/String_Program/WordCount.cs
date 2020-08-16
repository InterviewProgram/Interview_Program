using System;
using System.Collections.Generic;
using System.Text;

namespace String_Interview_Programm
{
    public class WordCount
    {
        // Get the count of the word in a sentence  
        public int GetWordCount(string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;

            str = str.Trim();
            var length = str.Split(' ').Length;
            return length;
        }
    }

}
