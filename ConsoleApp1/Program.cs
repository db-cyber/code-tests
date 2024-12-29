namespace HelloWorld;

class Program
{
    static void Main(string[] args){
    } 

    private static string ReverseString(string word)
    {
        var reversedString = string.Empty;

        for(var i = word.Length - 1; i >= 0; i--){
            reversedString += word[i];
        }

        return reversedString;
    }

    private static bool PalindromeCheck(string word) => 
        word == ReverseString(word);

    private static List<string> UniqueStringCheck(List<string> items)
    {
        var dict1 = new Dictionary<string, int>();

        foreach (var item in items)
        {
            if (dict1.TryGetValue(item, out _))
            {
                dict1[item] = dict1[item] + 1;
            }
            else
            {
                dict1.TryAdd(item, 1);
            }
        }

        var uniqueList = new List<string>();

        foreach (var item in dict1)
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

    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        //your code here
    }
}