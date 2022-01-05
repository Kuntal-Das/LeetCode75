using LeetCode75.Helpers;

namespace LeetCode75;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> indexes = new();

        int i = 0;
        while (i < nums.Length)
        {
            int findnum = target - nums[i];
            if (indexes.ContainsKey(findnum))
                return new int[] { indexes[findnum], i };
            if (!indexes.ContainsKey(nums[i]))
                indexes.Add(nums[i], i);
            i++;
        }
        return new int[1];
    }
}