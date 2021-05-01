using System;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromePermutation palindromePermutation = new PalindromePermutation();

            //permutation means rearrangement of string characters aab => aba which is palindrome!
            Console.WriteLine(palindromePermutation.checkPalindromePermutation("aab")); //returns true 

            Console.WriteLine(palindromePermutation.checkPalindromePermutation("code"));//returns false
        }
    }
}
