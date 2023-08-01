// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Hello World");
    }

    public static int MathChallenge(int fahrenheit)
    {
        int celcius = (fahrenheit * 32) * (5 / 9);
        return celcius;
    }
}

