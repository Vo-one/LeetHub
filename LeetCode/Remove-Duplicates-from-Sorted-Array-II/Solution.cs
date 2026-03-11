1public class Solution {
2    public int RemoveDuplicates(int[] nums) {
3        int k = 2;
4        if(nums.Length <= 2) 
5        {
6            return nums.Length;
7        }
8        for(int i = 2; nums.Length > i; i++)
9        {
10            if(nums[i] != nums[k - 2]) 
11            {
12                nums[k] = nums[i];
13                k++;
14            }
15        }
16        return k;
17    }
18}