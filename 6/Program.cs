using System;

public class Program
{
    public static void Main()
    {
        string input = "A man a plan a canal Panama";
        bool isPalindrome = IsPalindrome(input);
        Console.WriteLine("Is the string a palindrome? " + isPalindrome);
    }

    public static bool IsPalindrome(string str)
    {
        if (str == null)
        {
            throw new ArgumentException("Input string cannot be null");
        }

        // Приведение строки к нижнему регистру и удаление пробелов и знаков препинания
        str = str.ToLower();
        char[] arr = str.ToCharArray();
        arr = Array.FindAll<char>(arr, (c => (char.IsLetterOrDigit(c))));
        str = new string(arr);

        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}