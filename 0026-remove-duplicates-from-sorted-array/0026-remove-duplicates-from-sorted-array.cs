public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 0, i = 0, n  = nums.Length,prev = nums[0];
        while(i<n-1)
        {
            while(i < n-1 && nums[i] == nums[i+1] ) 
            {
                
                i++;  
            }
            nums[k] = nums[i];
            k++;
            i++; 
        }
        if(i!=n)
        {
            nums[k] =  nums[i]; 
            k++;
        }
        return k;
        
    }
}