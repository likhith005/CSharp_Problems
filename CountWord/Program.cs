class Program{
    public static void Main(){
        string sentence = "Hello World";
        Console.WriteLine(sentence.Length);

        string[] words = sentence.Split(' ');
        int wordsCount = words.Length;
        Console.WriteLine($"number of words: {wordsCount}");
        
    }
}