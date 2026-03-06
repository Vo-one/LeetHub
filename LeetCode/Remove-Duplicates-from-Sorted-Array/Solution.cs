1public class Solution {
2    public int RemoveDuplicates(int[] nums) {
3        int k = 1;
4        for(int i = 1; i < nums.Length; i++)
5        {  
6            if(nums[i] != nums[k - 1])
7            {
8                nums[k] = nums[i];
9                k++;
10            }
11        }
12        return k;
13    }
14}