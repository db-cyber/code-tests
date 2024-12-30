public static class Kata 
{
  public static IEnumerable<string> FriendOrFoe (string[] names) {
    var friends = new List<string>();

    foreach (var name in names)
    {
        if(name.Length.Equals(4)){
            friends.Add(name);
        }
    }

    return friends.ToArray();
  }
}