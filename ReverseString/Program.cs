using System;
class Program {
    public static void Main() {
        Console.WriteLine("Enter word: ");
        string s = Console.ReadLine(); 
        Console.WriteLine(reverseString(s, "", s.Length - 1));
    }

    public static string reverseString(string s, string r, int i) {
        if (i < 0) {
            return r;
        }
        return reverseString(s, r + s[i], i - 1); 
    }
}
