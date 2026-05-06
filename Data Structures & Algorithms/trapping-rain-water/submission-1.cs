public class Solution {
    public int Trap(int[] height) {
        int totalTrappedWater =0;
        int left =0;
        int right =height.Length-1;
        int leftMax = height[left];
        int rightMax =height[right];

        while(left < right)
        {
            if(leftMax < rightMax)
            {
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                totalTrappedWater += leftMax - height[left];
            }else {
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                totalTrappedWater += rightMax - height[right];
            }
        }
        return totalTrappedWater;
    }
}
