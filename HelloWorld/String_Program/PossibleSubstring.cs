using System;
using System.Collections.Generic;
using System.Text;

namespace String_Interview_Programm
{
    public class PossibleSubstring
    {
        // Get the possible substring in a string  
        public void GetPossibleSubstring(string word)
        {
            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 1; i < word.Length; i++)
                {
                    for (int j = 0; j <= word.Length - i; j++)
                    {
                        Console.WriteLine(word.Substring(j, i));
                    }
                }

                //  Console.ReadLine();
            }
        }
    }

}
