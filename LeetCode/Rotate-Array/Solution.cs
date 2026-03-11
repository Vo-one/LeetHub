1public class Solution {
2    public void Rotate(int[] nums, int k) {
3        int n = nums.Length;
4        int[] tmp = new int[n];
5
6        for(int i = 0; n > i; i++)
7        {
8            tmp[(i + k) % n] = nums[i];
9            
10        }Array.Copy(tmp, nums, n);
11    }
12}