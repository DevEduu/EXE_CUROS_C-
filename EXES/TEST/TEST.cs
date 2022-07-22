
using System;
using System.Linq;
 
public class Example
{
    public static void Main()
    {
        String s = "a, b, c, d";
 
        s = new string(s.Where(c => !char.IsPunctuation(c)).ToArray());
 
        Console.WriteLine(s);        //abcd
    }
}