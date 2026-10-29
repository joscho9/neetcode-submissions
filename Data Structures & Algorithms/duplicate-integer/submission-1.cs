public class Solution {

     public bool hasDuplicate(int[] nums) {

        var hashset = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++) {
            if(hashset.Contains(nums[i])) return true;
            hashset.Add(nums[i]);
        }
        return false;
    }

    public bool hasDuplicateBruteForce(int[] nums) {
        for (int i = 0; i < nums.Length; i++) {
            for(int j = i+1; j < nums.Length; j++)
            {
                if( nums[i] == nums[j]) return true;
            }
        }
        return false;
    }
}