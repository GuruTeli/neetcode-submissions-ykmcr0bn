public class Solution {
    public int[] TwoSum(int[] nums, int target) {


            int[] indices = new int[2];
            Dictionary<int, int> map = new Dictionary<int, int>();

            for(int i=0; i< nums.Length; i++)
            {
                  int comp = target - nums[i];
                  if( map.ContainsKey(comp))
                  {
                      indices[0] = map[comp];
                      indices[1] = i;
                      break;
                  }

                  map.Add(nums[i],i);
            }
            return indices;

    }
}
