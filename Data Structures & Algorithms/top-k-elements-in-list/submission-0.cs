public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
          Dictionary<int,int> frequencyMap = new Dictionary<int,int>();
          foreach(int i in nums)
          {
            if(frequencyMap.ContainsKey(i))
            {
                frequencyMap[i]+=1;
                continue;
            }
            frequencyMap[i]=1;
          }
       return frequencyMap.OrderByDescending(entry => entry.Value)
                          .Take(k)
                          .Select(entry => entry.Key)
                          .ToArray();
                          
        
    }
}
