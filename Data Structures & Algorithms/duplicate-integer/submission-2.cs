public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> unique = new();
        for(int i=0; i< nums.Length; i++)
        {
            if(!unique.Add(nums[i]))
            {
                return true;
            }
        }
        return false;
    }
}