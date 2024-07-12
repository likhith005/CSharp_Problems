class Calculator{
    public static void Main(){
        do{
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator: \n \t + \t - \t * \t / \t %");
            string op = Console.ReadLine();

            switch(op){
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = " + result);
                    break;
                case "%":
                    result = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = " + result);
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            Console.WriteLine("Would you like to continue? (Y=yes, N=no): ");
        }while(Console.ReadLine().ToUpper() == "Y");

        Console.WriteLine("Bye!");
    }
}