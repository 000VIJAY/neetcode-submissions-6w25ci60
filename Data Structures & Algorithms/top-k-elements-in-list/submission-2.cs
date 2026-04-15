public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> keyVal =new();
        PriorityQueue<int, int> pq = new ();
        int[] result = new int[k];

        for (int i=0; i< nums.Length; i++)
        {
            if(!keyVal.ContainsKey(nums[i])) keyVal[nums[i]] = 0;
            keyVal[nums[i]]++;
        }

        foreach(var kv in keyVal)
        {
           pq.Enqueue(kv.Key, kv.Value);
           if(pq.Count >k)
           {
                pq.Dequeue();
           }
        }

        for(int  i=0; i<k; i++)
        {
            result[i] = pq.Dequeue();
        }
        return result;
    }
    
}
