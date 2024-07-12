class Program{
    public static void Main(){
        int[] arr = {9,1,8,2,7,3,6,4,3};
        foreach(int i in arr){
            Console.Write(i + " ");
        }

        Console.WriteLine();

        bubbleSort(arr);
        foreach(int i in arr){
            Console.Write(i + " ");
        }
    }
    public static void bubbleSort(int[] arr){
        for(int i=0;i<arr.Length-1;i++){
            for(int j=0;j<arr.Length-i-1;j++){
                if(arr[j]>arr[j+1]){
                    int temp = arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                }
            } 
        }
    }
}

// using System;

// public class Program {
//     public static void Main() {
//         string input = "hello";
//         string sortedString = BubbleSortString(input);
        
//         Console.WriteLine($"Original String: {input}");
//         Console.WriteLine($"Sorted String  : {sortedString}");
//     }

//     public static string BubbleSortString(string input) {
//         char[] chars = input.ToCharArray(); // Convert string to character array

//         // Bubble sort algorithm
//         for (int i = 0; i < chars.Length - 1; i++) {
//             for (int j = 0; j < chars.Length - i - 1; j++) {
//                 if (chars[j] > chars[j + 1]) {
//                     // Swap characters
//                     char temp = chars[j];
//                     chars[j] = chars[j + 1];
//                     chars[j + 1] = temp;
//                 }
//             }
//         }

//         // Convert character array back to string
//         string sortedString = new string(chars);
//         return sortedString;
//     }
// }
