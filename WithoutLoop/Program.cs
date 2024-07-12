// // using System;
// // class Program{
// //     public static void Main(){
// //         string name = "Raju";
// //         string s = "i";

// //         s = s.Replace("i", "iiiiiiiiii");
// //         s = s.Replace("i", "iiiiiiiiii");
// //         s = s.Replace("i", "iiiiiiiiii");

// //         s = s.Replace("i", name + "\n");
// //         Console.WriteLine(s);
// //     }
// // }

// using System;
// using System.Net;
// class Program{
//     public static void Main(){
//         printNtimes("Jai Sree Ram", 1000);
//     }
//     public static void printNtimes(string message, int count){
//         if(count>0){
//             Console.WriteLine(message);
//             printNtimes(message, count - 1);
//         }
//     }
// }

using System;
class Program{
    public static void Main(){
        printNumbers(1,100);
    }
    public static void printNumbers(int firstnumber, int lastnumber){
        if(firstnumber <= lastnumber){
            Console.WriteLine(firstnumber);
            firstnumber++;
            printNumbers(firstnumber, lastnumber);
        }
    }
}