public class Program {
    public static void Main() {
        int a = 5;
        int b = 10;

        Console.WriteLine($"Before swapping: a = {a}, b = {b}");
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"uisng temp: a = {a}, b = {b}");

        Console.WriteLine();

        Console.WriteLine($"Before swapping: a = {a}, b = {b}");

        a = a + b;  // a now holds the sum of both numbers
        b = a - b;  // b now holds the original value of a
        a = a - b;  // a now holds the original value of b

        Console.WriteLine($"After swapping: a = {a}, b = {b}");

        Console.WriteLine();

        Console.WriteLine($"Before swapping: a = {a}, b = {b}");

        a = a ^ b;  
        b = a ^ b;  
        a = a ^ b;  

        Console.WriteLine($"After swapping: a = {a}, b = {b}");
    }
}
