// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Hello World");
    }

    public static void StringBuilderMethod()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Hello World");
        for (int i = 0; i < 4; i++)
        {
            stringBuilder.Append("nice to see you");
        }
        string s = stringBuilder.ToString();
        System.Diagnostics.Debug.WriteLine(s);
    }
}
