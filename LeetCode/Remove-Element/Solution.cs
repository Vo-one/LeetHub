1public class Solution {
2    public int RemoveElement(int[] nums, int val) {
3    int k = 0;
4
5     for (int i = 0; i < nums.Length; i++) 
6     {
7        if(nums[i] != val){
8            nums[k] = nums[i]; 
9            k++;
10        }
11     }
12    return k;
13    }
14}