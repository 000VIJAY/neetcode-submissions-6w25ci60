public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> keyVal =new();
        List<int> result = new();

        for (int i=0; i< nums.Length; i++)
        {
            if(!keyVal.ContainsKey(nums[i])) keyVal[nums[i]] =0;
            keyVal[nums[i]]++;
        }

        var sortedDict = keyVal.OrderByDescending(x => x.Value); 
        
        foreach(var key in sortedDict)
        {
            result.Add(key.Key);
            if(result.Count ==k)
            {
                break;
            }
        }
        return result.ToArray();
    }
}
