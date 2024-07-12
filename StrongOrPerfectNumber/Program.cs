class Program{
    public static void Main(){
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        bool result = isPerfect(n);
        
        if (result)
        {
            Console.WriteLine($"{n} is a perfect number.");
        }
        else
        {
            Console.WriteLine($"{n} is not a perfect number.");
        }
    }

    public static bool isPerfect(int n){
        int sum = 0;
        for(int i=1;i<=n;i++){
            if(n%i==0){
                return true;
            }
        }
        return false;
    }
}