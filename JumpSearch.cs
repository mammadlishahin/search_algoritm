
class JumpSearch
{
    public static int JumpSearchAlgorithm(int[] array, int target)
    {
        int n = array.Length;
        
        int step = (int)Math.Floor(Math.Sqrt(n));

        int prev = 0;

        while (array[Math.Min(step, n) - 1] < target)
        {
            prev = step;
            step += (int)Math.Floor(Math.Sqrt(n));
            if (prev >= n)
                return -1; 
        }

        while (array[prev] < target)
        {
            prev++;

            if (prev == Math.Min(step, n))
                return -1; 
        }

        if (array[prev] == target)
            return prev;

        return -1; 
    }

    
}
