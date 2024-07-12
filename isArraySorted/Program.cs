class Program{
    public static void Main(){
        int[] arr = {2,3,4,5,6,7,8,9};
        bool result = isArraySorted(arr);
        Console.WriteLine(result);
    }
    public static bool isArraySorted(int[] arr){
        for(int i=1;i<arr.Length;i++){
            if(arr[i]<arr[i-1]){
                return false;
            }
        }
        return true;
    }
}