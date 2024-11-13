using System;

class Program{
    static void Main(){
        Console.Write("Enter first number: ");
        float num1 = float.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        float num2 = float.Parse(Console.ReadLine());
        Console.Write("Enter an operator (+,-,*,/): ");
        char op = char.Parse(Console.ReadLine());

        float result = 0f;

        switch(op){
            case '+':
                result = num1+num2;
                Console.WriteLine("The addition is {0}", result);
                break;
            case '-':
                result = num1-num2;
                Console.WriteLine("The subraction is {0}", result);
                break;
            case '*':
                result = num1*num2;
                Console.WriteLine("The multiplication is {0}", result);
                break;
            case '/':
                result = num1/num2;
                Console.WriteLine("The division is {0}", result);
                break;
            default:
                Console.WriteLine("Invalid Choice!");
                break;
        }
    }
}