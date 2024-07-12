class Program{
    public static void Main(){
        Console.WriteLine("Enter a word: ");
        string n = Console.ReadLine();
        bool result = isVowel(n);
        Console.WriteLine(result);

        int countVowelsResult = countVowels(n);
        Console.WriteLine($"Number of vowels: {countVowelsResult}");
    }
    public static bool isVowel(string input){
        string vowels ="aeiouAEIOU";
        foreach(char c in vowels){
            if(input.Contains(c)){
                return true;
            }
        }
        return false;
    }

    public static int countVowels(string input){
        string vowels ="aeiouAEIOU";
        int count=0;
        foreach(char c in input){
            if(vowels.Contains(c)){
                count++;
            }
        }
        return count;
    }
}