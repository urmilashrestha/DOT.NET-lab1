using System;

class Program{
    static void Main(){
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine(name);
        Console.WriteLine("Welcome {0}, to dotnet technology", name);
    }
}