using System;
using System.Linq;

namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            bool result = solution.IsPalindrome(121);
            Console.WriteLine(result); // Expected output: True
            result = solution.IsPalindrome1(121);
            Console.WriteLine(result);
            result = solution.IsPalindrome(-121);
            Console.WriteLine(result); // Expected output: False
            result = solution.IsPalindrome1(-121);
            Console.WriteLine(result);
            result = solution.IsPalindrome(10);
            Console.WriteLine(result); // Expected output: False
            result = solution.IsPalindrome1(10);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        
    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            // Convert the number to a string
            string str = x.ToString();
            // Reverse the string
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversedStr = new string(charArray);

            // Check if the original string is equal to the reversed string
            return str == reversedStr;
        }
        public bool IsPalindrome1(int x)
        {
            var reverseCharArray = x.ToString().Reverse();

            var reverseString = String.Empty;

            foreach (var character in reverseCharArray)
                reverseString += character;

            if (x.ToString() != reverseString)
                return false;
            return true;
        }
    }
}
