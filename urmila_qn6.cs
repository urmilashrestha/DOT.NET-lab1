using System;

class Program{
    static void Main(){
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Before swapping: num1 = {0}, num2 = {1}", num1, num2);
        int temp;
        temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("After swapping: num1 = {0}, num2 = {1}", num1, num2);
    }
}