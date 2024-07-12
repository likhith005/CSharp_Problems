class Program{
    public static void Main(){
        Console.WriteLine("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(countNum(n));
    }
    public static int countNum(int n){
        int count = 0;
        while(n>0){
            n=n/10;
            count++;
        }
        return count;
    }
}