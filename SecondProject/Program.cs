// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        TimeSpan timeSpan = new TimeSpan(1, 2, 3);
        Console.WriteLine(timeSpan.Hours); // 1
        Console.WriteLine(timeSpan.Minutes); // 2
        Console.WriteLine(timeSpan.Seconds); // 3
    }
        
}
