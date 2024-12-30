public class FindNextSquareKata
{
    public static long FindNextSquare(long num)
    {
        long value = -1;
        if (Math.Sqrt(num) % 1 == 0)
        {
            for (var i = num + 1; value != 0; i++)
            {
                if (Math.Sqrt(i) % 1 == 0)
                {
                    value = i;
                    break;
                };
            }
        }

        return value;
    }
}