class Program{
    public static void Main(){
        int[] arr = {50,10,33,40,26};
        int key = 40;
        Console.WriteLine(linearSearch(arr,key)); 
    }
    public static int linearSearch(int[] a, int key){
        for(int i=0;i<a.Length;i++){
            if(a[i] == key){
                return i;
            }
        }
        return -1;
    }
}