1public class Solution {
2    public void Merge(int[] nums1, int m, int[] nums2, int n) {
3        int i = m - 1; //конец 1м
4        int j = n - 1; //конец 2м
5        int k = m + n - 1; //конец итогового
6
7        while(i >= 0 && j >= 0)
8        {
9            if(nums1[i] > nums2[j])
10            {
11                nums1[k] = nums1[i];
12                i--;
13            } 
14            else
15            {
16                nums1[k] = nums2[j];
17                j--;
18            }
19           k--;
20        }
21        while(j >= 0){
22            nums1[k] = nums2[j];
23            j--;
24            k--;
25        }
26    }
27}