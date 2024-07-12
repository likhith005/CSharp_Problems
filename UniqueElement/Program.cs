class Program{
    public static void Main(){
        int[] arr = {2,2,3,3,4,5,5,6,7,6,7};
        for(int i=0;i<arr.Length;i++){
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();

        int unique = lonelyInteger(arr);
        Console.WriteLine("\nThe lonely integer is: " + unique);
        
    }
    public static int lonelyInteger(int[] arr){
        int uni=0;
        foreach(int val in arr){
            uni ^= val;
        }
        return uni;
    }
}