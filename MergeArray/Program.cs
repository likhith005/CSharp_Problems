using System;
using System.Linq; // Needed for Union and ToArray

class Program {
    public static void Main() {
        int[] number1 = {11, 22, 33, 44, 55};
        int[] number2 = {44, 33, 11, 66, 77};

        // Union the two arrays and convert to array
        int[] numbers = number1.Union(number2).ToArray();

        Console.WriteLine("Array1:");
        printArrays(number1);

        Console.WriteLine("\nArray2:");
        printArrays(number2);

        Console.WriteLine("\nMerged Array:");
        printArrays(numbers);
    }

    public static void printArrays(int[] arr) {
        foreach (var item in arr) {
            Console.Write(item + " ");
        }
        Console.WriteLine(); 
    }
}
