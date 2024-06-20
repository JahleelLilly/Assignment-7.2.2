namespace Assignment_7._2._2
{
    class Program
    {
        static string ReverseVowels(string s)
        {
            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            char[] chars = s.ToLower().ToCharArray();

            int left = 0, right = chars.Length - 1;

            while (left < right)
            {
                if (vowels.Contains(chars[left]) && vowels.Contains(chars[right]))
                {
                    char temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;
                    left++;
                    right--;
                }
                else if (vowels.Contains(chars[left]))
                    right--;
                else
                    left++;
            }

            return new string(chars);
        }

        static void Main()
        {
            Console.WriteLine(ReverseVowels("hello")); // Output: "holle"
            Console.WriteLine(ReverseVowels("avacado")); // Output: "ovacada"
            Console.WriteLine(ReverseVowels("intelligent")); // Output: "entillegint"
        }
    }
}