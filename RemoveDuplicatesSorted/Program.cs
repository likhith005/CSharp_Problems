class Program{
    public static void Main(){
        int[] arr ={6,6,7,2,3,2,9,9};
        Array.Sort(arr);
        for(int i=0;i<arr.Length;i++){
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();

        int rd = removeDuplicates(arr);
        for(int i=0;i<rd;i++){
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();

        int[] uniqueList = removeD(arr);
        for(int i=0;i<uniqueList.Length;i++){
            Console.Write(uniqueList[i] + " ");
        }
    }
    public static int removeDuplicates(int[] arr){
        int rd=0;
        for(int i=1;i<arr.Length;i++){
            if(arr[rd]!=arr[i]){
                rd++;
                arr[rd]=arr[i];
            }
        }
        return rd+1;
    }

    public static int[] removeD(int[] arr){
        HashSet<int> seen = new HashSet<int>();
        List<int> uniqueList = new List<int>();
        foreach(int num in arr){
            if(!seen.Contains(num)){
                seen.Add(num);
                uniqueList.Add(num);
            }
        } 
        return uniqueList.ToArray();
    }
}