class Program{
    public static void Main(){
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Factorial (recursive) of {n} is: {Factorial(n)}");
        Console.WriteLine($"Factorial (iterative) of {n} is: {FactorialFor(n)}");
    }
    public static int factorial(int n){
        if(n==0 || n==1){
            return 1;
        }
        return n * factorial(n-1);
    }

    public static long factorialfor(int n){
        long fact = 1;
        for(int i=1;i<=n;i++){
            fact = fact * i;
        }
        return fact;
    }
}