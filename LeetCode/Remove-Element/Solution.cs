1public class Solution {
2    public int RemoveElement(int[] nums, int val)
3    {
4        int k = 0;
5        foreach (var x in nums) if (x != val) nums[k++] = x;
6        return k;
7    }
8}