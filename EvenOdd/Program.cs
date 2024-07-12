// using System;

// class Program {
//     public static void Main() {
//         Console.WriteLine("Enter a number: ");
//         int n = Convert.ToInt32(Console.ReadLine());

//         if (n % 2 == 0) {
//             Console.WriteLine($"{n} is even.");
//         } else {
//             Console.WriteLine($"{n} is odd.");
//         }
//     }
// }


using System;

class Program {
    public static void Main() {
        Console.WriteLine("Enter the lower limit (integer): ");
        int lowerLimit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the upper limit (integer): ");
        int upperLimit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Even numbers from {lowerLimit} to {upperLimit}:");
        
        int sum = 0;
        for (int i = lowerLimit; i <= upperLimit; i++) {
            if (i % 2 == 0) {
                Console.Write(i + " ");
                sum += i;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"Sum of even numbers from {lowerLimit} to {upperLimit} is: {sum}");
    }
}
