namespace _3Sum_Neetcode_Medium_;

public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        List<List<int>> triplets = new List<List<int>>();

        HashSet<string> added = new HashSet<string>();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        List<int> triplet = new List<int> {nums[i], nums[j], nums[k]};
                        triplet.Sort();
                        string trip = $"{triplet[0]} + {triplet[1]} + {triplet[2]}";
                        if (added.Add(trip))
                        {
                            triplets.Add(triplet);    
                        }
                    }
                }
            }
        }
        return triplets;
    }
}