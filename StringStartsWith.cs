using System;

// Check Given String is Start with Hello or Not.
class CheckStartsWith{
    public static void Main(string []args)
    {
       Console.WriteLine("Enter the String: ");
       string input = Console.ReadLine();
       
       Console.WriteLine(input.StartsWith("Hello"));
    }
}
