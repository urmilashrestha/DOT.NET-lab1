using System;

class Program{
    static void Main(){
        string[] str_array = {"Hello", "I am", "Urmila!"};
        Console.WriteLine("Individual string:");
        for(int i=0; i<str_array.Length; i++){
            Console.WriteLine(str_array[i]);
        }
        string result_str = string.Join(" ", str_array);
        Console.WriteLine("Combined string: {0}", result_str);
    }
}