class Program{
    public static void Main(){
        Console.WriteLine("Enter number a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(GCD(a,b));
        Console.WriteLine(LCM(a,b));
    }
    public static int GCD(int a, int b){
        // while(a!=b){
        //     if(a>b){
        //         a=a-b;
        //     }else{
        //         b=b-a;
        //     }
        // }
        // return a;

        while(a!=0 && b!=0){
            if(a>b){
                a=a%b;
            }else{
                b=b%a;
            }
        }
        if(a!=0){
            return a;
        }else{
            return b;
        }
    }

    public static int LCM(int a, int b){
        return (a*b)/GCD(a,b);
    }
}