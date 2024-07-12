class Program{
    public static void Main(){
        Console.WriteLine("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = reverseNumber(n);
        Console.WriteLine(result);
    }
    public static int reverseNumber(int num){
        int reversed = 0;
        while(num!=0){
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num = num / 10;
        }
        return reversed;
    }
}