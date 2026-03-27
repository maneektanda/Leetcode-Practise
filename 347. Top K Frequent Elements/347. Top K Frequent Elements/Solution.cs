namespace _347._Top_K_Frequent_Elements;

class Solution
{
    public static int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> num_frequencies = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (num_frequencies.ContainsKey(nums[i]))
            {
                num_frequencies[nums[i]]++;
            }
            else
            {
                num_frequencies.Add(nums[i], 1);
            }
        }
        
        Comparer<int> max_heap = Comparer<int>.Create((x, y) => y.CompareTo(x));
        PriorityQueue<int, int> ordered_frequencies = new PriorityQueue<int, int>(max_heap);

        foreach (KeyValuePair<int, int> num in num_frequencies)
        {
            ordered_frequencies.Enqueue(num.Key, num.Value);
        }

        int[] result = new int[k];

        for (int i = 0; i < k; i++)
        {
            result[i] = ordered_frequencies.Dequeue();
        }

        return result;
    }
}