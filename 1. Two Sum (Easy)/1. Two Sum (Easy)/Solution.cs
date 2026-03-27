namespace _1._Two_Sum__Easy_;

class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> compliments = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int compliment = target - nums[i];
            if (compliments.ContainsKey(compliment))
            {
                int[] result = [compliments[compliment], i];
                return result;
            }
            else
            {
                compliments.Add(nums[i], i);
            }
            
        }
        int[] no_result = [];
        return no_result;
    }
}