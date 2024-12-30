public class Calculations
{
    public static string ReverseString(string word)
    {
        var reversedString = string.Empty;

        for(var i = word.Length - 1; i >= 0; i--){
            reversedString += word[i];
        }

        return reversedString;
    }

    public static bool PalindromeCheck(string word) => 
        word == ReverseString(word);

    public static List<string> UniqueStringCheck(List<string> items)
    {
        var countDictionary = new Dictionary<string, int>();

        foreach (var item in items)
        {
            if (countDictionary.TryGetValue(item, out _))
            {
                countDictionary[item] = countDictionary[item] + 1;
            }
            else
            {
                countDictionary.TryAdd(item, 1);
            }
        }

        var uniqueList = new List<string>();

        foreach (var item in countDictionary)
        {
            if(item.Value == 1)
            {
                uniqueList.Add(item.Key);
            }
        }

        return uniqueList;
    }

    public static bool IsSquare(int n) =>
        Math.Sqrt(n) % 1 == 0;
}

