namespace _33._Search_in_Rotated_Sorted_Array;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    int Search(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length - 1;

        while (l <= r)
        {
            int m = r - ((r - l) / 2);
            if (nums[m] == target) return m;

            // 7 8 9 1 2 3 4 5 6

            // 4 5 6 7 8 9 1 2 3
            // find which side is sorted, check if target in those bounds, if yes, check that side, otherwise check other side.
            
            // if left side is sorted 
            if (nums[l] <= nums[m])
            {
                // and target is inbetween those bounds, then search left side
                if (nums[l] <= target && nums[m] >= target)
                {
                    r = m - 1;
                }
                // otherwise search other side
                else
                {
                    l = m + 1;
                }
            }
            // otherwise right side has to tbe the sorted side
            else 
            {
                // and target inbetween those bounds
                if (nums[m] <= target && nums[r] >= target)
                {
                    l = m + 1;
                }
                // otherwise search other side
                else
                {
                    r = m - 1;
                }
            }
        }
        return -1;
    }
}
