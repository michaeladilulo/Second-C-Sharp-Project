// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        Person p = new Person();
        p.Name = "Old Name";
        ChangeReferenceType(p);
        System.Diagnostics.Debug.WriteLine(p.Name);
    }

   public class Person
    {
        public string ?Name;
    }

    static void ChangeReferenceType(Person person)
    {
        person.Name = "New Name";
    }
}
