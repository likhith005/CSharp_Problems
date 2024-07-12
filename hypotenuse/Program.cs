class Hypertenuse{
    public static void Main(){
        Console.WriteLine("Enter side A: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter side B: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double c = Math.Sqrt((a*a)+(b*b));
        Console.WriteLine("Hypertenuse of give sides is {0}",c);

    }
}