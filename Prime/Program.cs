// class Prime{
//     public static void Main(){
//         int num=5, i;
//         for(i=2;i<num;i++){
//             if(num%i==0){
//                 Console.WriteLine("Not a Prime");
//                 break;
//             }
//         }
//         if(num == i){
//             Console.WriteLine("Prime");
//         }
//     }
// }




// class Program{
//     public static void Main(){
//         Console.WriteLine("Enter the number: ");
//         int num = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine(checkPrime(num));
//     }
//     public static bool checkPrime(int n){
//         if(n==2 || n==3){
//             return true;
//         }
//         if(n==1){
//             return false;
//         }
//         if(n%2==0 || n%3==0){
//             return false;
//         }
//         for(int i=5;i*i<=n;i+=6){
//             if(n%i==0 || n%(i+2)==0){
//                 return false;
//             }
//         }
//         return true;
//     }
// }

class Program{
    public static void Main(){
        Console.WriteLine("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(isPrime(num));
    }

    public static bool isPrime(int n){
        if(n==1){
            return false;
        }
        if(n%2==0 || n%3==0){
            return false;
        }
        if(n==2 || n==3){
            return true;
        }
        for(int i=5;i*i<=n;i+=6){
            if(n%i==0 || n%(i+2)==0){
                return false;
            }
        }
        return true;
    }
}