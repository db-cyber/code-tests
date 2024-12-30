using System;

public static class PeopleLikes
{
    public static string Likes(string[] name) =>
        name.Length switch
        {
            1 => $"{name[0]} likes this",
            2 => $"{name[0]} and {name[1]} like this",
            3 => $"{name[0]}, {name[1]} and {name[2]} like this",
            >= 4 => $"{name[0]}, {name[1]} and {name.Length - 2} others like this",
            _ => "no one likes this"
        };
}