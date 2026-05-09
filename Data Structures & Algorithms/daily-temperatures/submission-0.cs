public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> dailyTemp  = new ();
        int[] temp = new int[temperatures.Length];
        int pastDayIndex =0;

        for(int i = 0; i< temperatures.Length; i++)
        {
            while(dailyTemp.Count >0 && temperatures[i] > temperatures[dailyTemp.Peek()])
            {
                pastDayIndex = dailyTemp.Pop();
                temp[pastDayIndex] =  i - pastDayIndex;
            }
            dailyTemp.Push(i);
        }
        return temp;
    }
}
