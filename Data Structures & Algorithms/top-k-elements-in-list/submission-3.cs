public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> keyVal =new();
        List<int>[] bucket = new List<int>[nums.Length+1];
        int[] result = new int[k];

        for (int i=0; i< nums.Length; i++)
        {
            if(!keyVal.ContainsKey(nums[i])) {
                keyVal[nums[i]] = 0; 
            }
            keyVal[nums[i]]++;
        }

        foreach(var kv in keyVal)
        {
            int key = kv.Key;
            int value = kv.Value;
            if(bucket[value]==null)
            {
                bucket[value] = new List<int>();
            }
            bucket[value].Add(key);
        }

        int resultIndex =0;

        for(int i=bucket.Length-1; i>=0; i--)
        {
                if(bucket[i] != null)
                {
                    foreach (int num in bucket[i]) 
                    {
                        result[resultIndex] = num;
                        resultIndex++;
                        if (resultIndex == k) 
                        {
                            return result;
                        }
                    }
                }
        }        
        return result;
    }
    
}
