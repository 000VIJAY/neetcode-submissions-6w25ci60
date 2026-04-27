public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length <1) return 0;

        Array.Sort(nums);

        int maxCons = 1;
        int currentCons =1;

        for(int i =1; i< nums.Length; i++)
        {
            if(nums[i-1] == nums[i]) continue;

            if(nums[i] -1 == nums[i-1])
            {
                currentCons++;
            }else{
                maxCons = Math.Max(currentCons, maxCons);
                currentCons =1;
            }
        }

        return Math.Max(currentCons, maxCons);
    }
}
