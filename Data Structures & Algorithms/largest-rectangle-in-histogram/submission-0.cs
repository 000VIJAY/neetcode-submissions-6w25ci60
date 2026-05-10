public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<(int index, int height)> stacked = new ();
        int maxArea = 0;
        for(int i =0; i< heights.Length; i++)
        {
            int startIndex =i;
            while(stacked.Count > 0 && stacked.Peek().height > heights[i])
            {
                var popped =  stacked.Pop();
                var area = popped.height * (i - popped.index);

                maxArea =  Math.Max(maxArea, area);
                startIndex = popped.index;
            }

            stacked.Push((startIndex, heights[i]));
        }

        while(stacked.Count > 0)
        {
            var popped =  stacked.Pop();
            var area = popped.height *(heights.Length - popped.index);

            maxArea =  Math.Max(maxArea, area);
        }

        return maxArea;
    }
}
