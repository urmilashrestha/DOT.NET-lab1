using System;
using System.Linq;

class Program{
    static void Main(){
        int n;
        float[] marks;
        float min, max, sum = 0f, avg;
        Console.Write("Enter how many marks: ");
        n = int.Parse(Console.ReadLine());
        marks = new float[n];
        Console.WriteLine("Enter {0} marks:", n);
        for(int i=0; i<n; i++){
            marks[i] = float.Parse(Console.ReadLine());
        }
        for(int i=0; i<n; i++){
            sum+=marks[i];
        }
        min = marks.Min();
        max = marks.Max();
        avg = sum/n;
        Console.WriteLine("Min: {0}\nMax: {1}\nAverage: {2}", min, max, avg);
    }
}