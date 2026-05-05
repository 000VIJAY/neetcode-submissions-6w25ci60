public class Solution {
    public int MaxArea(int[] heights) {
        int max =0;
        int left =0;
        int right = heights.Length-1;
       
        while(left < right)
        {
            int currentMax =  (right-left) *Math.Min(heights[left], heights[right]);

            if(heights[left] < heights[right])
            {
                left++;
            }else{
                right--;
            }

            max = Math.Max(max, currentMax);
        }

        return max;
    }
}
