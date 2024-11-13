using System;

class Program{
    static void Main(){
        string str = "Urmila";
        Console.WriteLine("Original string: {0}", str);
        //converting string to character array
        char[] str_char = str.ToCharArray();
        //reversing the character array
        Array.Reverse(str_char);
        //assigning reversed string value to new variable
        string reversed_str = new string(str_char);
        Console.WriteLine("Reversed string: {0}", reversed_str);
    }
}
