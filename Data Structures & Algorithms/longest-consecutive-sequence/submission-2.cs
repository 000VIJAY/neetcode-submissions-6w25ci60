public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length <1) return 0;

        HashSet<int> set = new HashSet<int>(nums);
        int maxCons = 0;

        foreach(var num in set)
        {
            if(!set.Contains(num-1))
            {
                int currentCons = 1;
                int currentNum = num;

                while(set.Contains(currentNum+1))
                {
                    currentNum++;
                    currentCons++;
                }
                maxCons = Math.Max(currentCons, maxCons);
            }
        }
        
        return maxCons;
    }
}
