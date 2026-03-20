1public class Solution {
2    public string AddStrings(string num1, string num2) {
3        var res = new StringBuilder();
4        
5        int carry = 0;
6        int p1 = num1.Length - 1;
7        int p2 = num2.Length - 1;
8
9        while(p1 >= 0 || p2 >= 0)
10        {
11            int x1 = p1 >= 0 ? num1[p1] - '0' : 0;
12            int x2 = p2 >= 0 ? num2[p2] - '0' : 0;
13
14            int value = (x1 + x2 + carry) % 10;
15            res.Append(value);
16
17            carry = (x1 + x2 + carry) / 10;
18
19            p1--;
20            p2--;
21        }
22        if(carry !=  0)
23        {
24            res.Append(carry);
25        }
26
27        var charArray = res.ToString().ToCharArray();
28        Array.Reverse(charArray);
29
30        return new string(charArray);
31    }
32}