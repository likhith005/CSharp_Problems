class Program{
    public static void Main(){
        Console.WriteLine("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Number of digits: " + CountDigits(n));
        Console.WriteLine("Sum of digits: " + SumDigits(n));
    }
    public static int CountDigits(int n){
        if(n==0){
            return 0;
        }
        return CountDigits(n/10)+1;
    }

    public static int SumDigits(int n){
        if(n==0){
            return 0;
        }
        return SumDigits(n/10)+n%10;
    }
}


