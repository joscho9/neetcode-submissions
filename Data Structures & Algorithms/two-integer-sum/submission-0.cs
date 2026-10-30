public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {

        var dict = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            int onlyPossibleValue = target - nums[i];

            if (dict.ContainsKey(onlyPossibleValue))
            {
                int smaller_index = dict.GetValueOrDefault(onlyPossibleValue);
                return [smaller_index, i];
            }
            else
            {
                dict.Add(nums[i], i);
            }
        }
        return [-1];

    }
}