using System;

class Program{
    static void Main(){
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your address: ");
        string address = Console.ReadLine();
        Console.Write("Enter your email: ");
        string email = Console.ReadLine();
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Address: {0}", address);
        Console.WriteLine("Email: {0}", email);
    }
}