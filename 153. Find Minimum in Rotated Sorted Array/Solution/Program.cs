namespace Solution;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public int FindMin(int[] nums)
    {
        int l = 0; 
        int r = nums.Length - 1;
        int min = nums[0];

        while (l <= r)
        {
            if (nums[l] < nums[r])
            {
                return Math.Min(min, nums[l]);
            }
            int m = r - ((r - l) / 2);
            min = Math.Min(min, nums[m]);
            if (nums[m] >= nums[l])
            {
                l = m + 1;
            }
            else
            {
                r = m - 1;
            }
        }
        return min;
    }
}