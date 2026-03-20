using System;
using System.Numerics;

public class Solution {
    public string AddStrings(string num1, string num2) {
        // Convert the strings to BigInteger
        BigInteger num1BigInt = BigInteger.Parse(num1);
        BigInteger num2BigInt = BigInteger.Parse(num2);

        // Add the numbers and convert the result back to a string
        string result = (num1BigInt + num2BigInt).ToString();
        
        return result;
    }
}
