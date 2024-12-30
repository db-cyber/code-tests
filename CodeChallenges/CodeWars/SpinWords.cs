using System.Collections.Generic;
using System.Linq;
using System;

public class SpinWords
{
    /*
    Write a function that takes in a string of one or more words, and returns the same string, but with all words that have five or more letters reversed (Just like the name of this Kata).
     Strings passed in will consist of only letters and spaces. Spaces will be included only when more than one word is present.
    */
    public static string GetSpinWords(string sentence)
    {
        var str = sentence.Split(" ");

        for (var i = 0; i < str.Length; i++)
        {
            if (str[i].Length > 4)
            {
                var reversedString = string.Empty;

                for (var n = str[i].Length - 1; n >= 0; n--)
                {
                    reversedString += str[i][n];
                }

                str[i] = reversedString;
            }
        }

        return string.Join(" ", str);
    }
}