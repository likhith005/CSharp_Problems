class Program{
    public static void Main(){
        Console.WriteLine("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        printN(n);
        Console.WriteLine(CountDigits(n));
        Console.WriteLine(SumDigits(n));
    }
    public static void printN(int n){
        if(n==0){
            return;
        }
        printN(n-1);
        Console.WriteLine(n);
    }
}