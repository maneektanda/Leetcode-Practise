namespace _128._Longest_Conescutive_Sequence;

class Solution
{
    public static int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        HashSet<int> seen = new HashSet<int>();
        PriorityQueue<int, int> order = new PriorityQueue<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (seen.Contains(nums[i]))
            {
                continue;
            }
            else
            {
                seen.Add(nums[i]);
                order.Enqueue(nums[i], nums[i]);
            }
        }
        int max = 0;
        int counter = 0;
        int previous = order.Dequeue();
        while (order.Count > 0)
        {
            int check = order.Dequeue();
            if (Math.Abs(previous - check) != 1)
            {
                if (counter > max)
                {
                    max = counter;
                    counter = 0;
                    previous = check;
                    continue;
                }
                if (counter <= max)
                {
                    counter = 0;
                    previous = check;
                    continue;
                }

            }
            counter++;
            previous = check;
        }
        return Math.Max(max + 1, counter + 1);
    }
}