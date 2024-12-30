using System;
using System.Globalization;

public class ToCamelCase
{
    /*
    Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, 
    also often referred to as Pascal case). The next words should be always capitalized.
    */
    public static string ConvertToCamelCase(string str)
    {
        if (!string.IsNullOrEmpty(str))
        {
            string[] items = str.Split(['_', '-', ' ']);

            for (var i = 1; i <= items.Length - 1; i++)
            {
                items[i] = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(items[i]);
            }

            return string.Join("", items);
        }

        return string.Empty;
    }
}