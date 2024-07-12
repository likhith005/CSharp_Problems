class Program{
    public static void Main(){
        Console.WriteLine("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        divisor(n);
    }
    public static void divisor(int n){
        for(int i=1;i<n;i++){
            if(n%i==0){
                Console.WriteLine(i);
            }
        }
    }
}