1public class Solution {
2    public int MajorityElement(int[] nums) {
3        int count = 0;
4        int comparison = 0;
5
6// Input: nums = [2,2,1,1,1,2,2]
7// Output: 2
8
9        foreach(var x in nums)
10        {
11            if(count == 0)
12            {
13                comparison = x;
14            }
15
16            if(comparison == x)
17            {
18                count++;
19            }
20            else
21            {
22                count--;
23            }
24        }
25        return comparison;
26    }
27}
28