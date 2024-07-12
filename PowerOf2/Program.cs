class Program{
    public static void Main(){
        Console.WriteLine("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(powerOf2(n));
    }
    public static bool powerOf2(int n){
        if(n==0){
            return false;
        }
        return (n&(n-1))==0;
    }
}