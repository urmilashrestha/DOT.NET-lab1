using System;

class Program{
    static void Main(){
        Console.WriteLine("Enter three integer values:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int sum = a+b+c;
        Console.WriteLine("The sum is {0}", sum);
    }
}