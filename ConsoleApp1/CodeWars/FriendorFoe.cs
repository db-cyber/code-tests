public static class FriendOrFoe
{
  /*
  Make a program that filters a list of strings and returns a list with only your friends name in it.
  If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours! Otherwise, you can be sure he's not...
  */
  public static IEnumerable<string> GetFriendOrFoe (string[] names) {
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