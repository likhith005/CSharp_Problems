using System;

class Program {
    public static void Main() {
        Console.WriteLine("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int temp = n;
        
        while (temp > 0) {
            int r = temp % 10;  // Extract the last digit
            sum += r;           // Add the digit to the sum
            temp /= 10;         // Remove the last digit
        }

        Console.WriteLine($"Sum of digits of {n} is: {sum}");
    }
}
