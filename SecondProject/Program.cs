// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
        Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy"));
        Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt"));
        Console.WriteLine(DateTime.Now.ToString("dddd, dd MMMM yy HH:mm:ss"));
    }
        
}
