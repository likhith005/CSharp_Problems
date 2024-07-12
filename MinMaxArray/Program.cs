class Program{
    public static void Main(){
        int[] ar = {1,2,3,4,5,6,7,8,9};
        findMinMax(ar);
    }
    public static void findMinMax(int[] arr){
        if(arr==null || arr.Length ==0) return;
        int min = arr[0];
        int max = arr[0];
        for(int i=0;i<arr.Length;i++){
            if(arr[i]<min){
                min=arr[i];
            }
            if(arr[i]>min){
                max=arr[i];
            }
        }
        Console.WriteLine($"min: {min}");
        Console.WriteLine($"max: {max}");
    }
}