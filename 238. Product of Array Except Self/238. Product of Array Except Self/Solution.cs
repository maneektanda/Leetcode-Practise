namespace _238._Product_of_Array_Except_Self;

class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] left = new int[nums.Length];
        left[0] = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            left[i] = left[i - 1] * nums[i - 1];
        }
        int[] right = new int[nums.Length];
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (i == nums.Length - 1)
            {
                right[i] = 1;
                continue;
            }
            right[i] = right[i + 1] * nums [i + 1];
        }
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = left[i] * right[i];
        }
        return result;
    }
}