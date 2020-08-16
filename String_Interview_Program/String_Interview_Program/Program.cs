using System;
using System.Reflection;

namespace String_Interview_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Interview Program ");

           
            // Steps to Call private method
            typeof(PrivateMethodClass).GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(new PrivateMethodClass(), null);



            //// Problem 1: Find duplicate characters in a string.
            DuplicateCharacters duplicate = new DuplicateCharacters();
            var value1 = duplicate.GetDuplicateCharacter("google");
            Console.WriteLine("Duplicate char in 'google' is = " + value1);

            // //Problem 2: Get all unique characters in a string.
            UniqueCharacters unique = new UniqueCharacters();
            var value2 = unique.GetUniqueCharFromString("google");
            Console.WriteLine("Duplicate char in 'google' is = " + value2);


            // // Problem 3: Reverse a string.
            ReverseTheString reverseThe = new ReverseTheString();
            var value3 = reverseThe.ReverseString("google");
            Console.WriteLine("Reversed string for 'google' is = " + value3);


            // // Problem 4: Reverse each word of the sentence (string).
            ReverseEachWord reverseEachWord = new ReverseEachWord();
            var value4 = reverseEachWord.ReverseEachString("My name is Interview");
            Console.WriteLine("Reversed string for 'My name is Interview' is = " + value4);


            // //  Problem 5: Get the word count in a sentence(string).
            WordCount wordCount = new WordCount();
            var value5 = wordCount.GetWordCount("My name is Interview");
            Console.WriteLine("Word count for the string 'My name   is Interview' is = " + value5);

            // // Problem 6: Check if a string is a palindrome or not.
            CheckStringPalindrome stringPalindrome = new CheckStringPalindrome();
            var value6 = stringPalindrome.CheckPalindrome("radar");
            Console.WriteLine("Is 'radar' palindrome? = " + value6);

            // //Problem 7: Check max occurrence of a character in the string. 
            CheckMaxOccuranceCharater checkMaxOccurance = new CheckMaxOccuranceCharater();
            var value7 = checkMaxOccurance.CheckMaxOccuranceOfChar("Hello World");
            Console.WriteLine("Multiple occurance char in 'Hello world' is = " + value7);

            // //Problem 8: Get all possible substring in a string. 
            PossibleSubstring possibleSubstring = new PossibleSubstring();
            possibleSubstring.GetPossibleSubstring("india");


            // // Problem 9: Get the first char of each word in capital letter.
            GetFirstCharacter getFirstCharacter = new GetFirstCharacter();
            getFirstCharacter.GetFirstCharForEachWord("I love my india.");


            // //Problem 10: Get the index of string using binary search.
            StringBinarySearch stringBinary = new StringBinarySearch();
            stringBinary.BinarySearchOnstring();

        }
    }
}
