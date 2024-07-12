class Program{
    public static void Main(){
        Console.WriteLine("Enter any word: ");
        string s = Console.ReadLine();

        bool result = isPalindrome(s, 0, s.Length - 1);
        Console.WriteLine(result); 
    }
    public static bool isPalindrome(string s, int i, int j){
        if (s[i] != s[j]) {
            return false;
        }
        if(j<=i){
            return true;
        }
        return isPalindrome(s,i+1,j-1);
    }
}