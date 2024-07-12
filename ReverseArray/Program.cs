class Program{
    public static void Main(){
        int[] arr = {2,3,4,5,6,7,8,9};
        for(int i=0;i<arr.Length;i++){
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        reverse(arr);
        for(int i=0;i<arr.Length;i++){
            Console.Write(arr[i]+ " ");
        }
    }
    public static void reverse(int[] arr){
        int i=0,j=arr.Length-1;
        while(i<j){
            int temp = arr[i];
            arr[i]=arr[j];
            arr[j]=temp;
            i++;
            j--;
        }
    }
}