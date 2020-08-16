using System;
using System.Collections.Generic;
using System.Text;

namespace String_Interview_Program
{
    public class GetFirstCharacter
    {
        // Get the first char of the each word  
        public void GetFirstCharForEachWord(string sentence)
        {
            if (!string.IsNullOrEmpty(sentence))
            {
                string[] arr = sentence.Split(' ');

                foreach (string item in arr)
                {
                    Console.Write(item.Substring(0, 1).ToUpper() + " ");
                }

                //  Console.ReadLine();
            }
        }
    }

}
