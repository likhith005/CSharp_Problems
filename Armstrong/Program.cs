class Program{
    public static void Main(){
        Console.WriteLine("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int r, sum=0;
        int temp = n;
        
        while(n>0){
            r=n%10;
            n=n/10;
            sum=sum + r*r*r;
        }

        string result = (temp == sum) ? "It is an Armstrong number" : "It is not an Armstrong number";
        Console.WriteLine(result);
    }
}