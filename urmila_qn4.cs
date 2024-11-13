using System;

class Program{
    static void Main(){
        Console.Write("Enter principle: ");
        int principle = int.Parse(Console.ReadLine());
        Console.Write("Enter time: ");
        float time = float.Parse(Console.ReadLine());
        Console.Write("Enter rate: ");
        float rate = float.Parse(Console.ReadLine());

        float simple_intrest = (principle*time*rate)/100;
        Console.WriteLine("Simple intrest is {0}", simple_intrest);
    }
}
