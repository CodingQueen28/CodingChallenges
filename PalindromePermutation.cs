namespace CodingChallenges
{
    public class PalindromePermutation
    {
        //Check if string's permutation is palindrome!
        public bool checkPalindromePermutation(string s)
        {
            int[] char_counts = new int[128]; //upper and lower case ASCII characters

            for (int i = 0; i < s.Length; i++)
            {
                char_counts[s[i]]++;
            }

            int count = 0;

            for (int i = 0; i < 128; i++)
            {
                if (char_counts[i] % 2 == 1)
                {
                    count++;
                }
            }
            if (count <= 1) return true; //if there is one odd character in strig which doesn't match with any other character it is palindrome
            return false;
        }
    }
}
