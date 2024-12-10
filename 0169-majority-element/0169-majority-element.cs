public class Solution {
    public int MajorityElement(int[] nums) {
           
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
            
           
            foreach (var num in nums)
            {
                if (!frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num] = 0;
                }
                frequencyMap[num]++;
            }
            
            
            return frequencyMap.FirstOrDefault(x => x.Value == frequencyMap.Values.Max()).Key;
    }
}