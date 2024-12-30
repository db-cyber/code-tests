using System;
using System.Text.RegularExpressions;

public class Printer
{
    public static string PrinterError(String s)
    {
        char[] characters = s.ToCharArray();
        var total = characters.Length;
        var failure = 0;

        foreach (var character in characters)
        {
            if (!Regex.IsMatch(character.ToString(), @"[a-m]", RegexOptions.IgnoreCase))
            {
                failure++;
            }
        }

        return $"{failure}/{total}";
    }
}