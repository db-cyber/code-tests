public static class Sum
{
    /*
    Given two integers a and b, which can be positive or negative, find the sum of all the integers between and including them and return it. If the two numbers are equal return a or b.
    Note: a and b are not ordered!
    */
     public static int GetSum(int a, int b)
     {
        var total = new int();
        var smallest = Math.Min(a, b);
        var largest = Math.Max(a, b);

        for(var i = smallest; i <= largest; i++){
            total += i;
        }

       return total;
     }                                                  
}