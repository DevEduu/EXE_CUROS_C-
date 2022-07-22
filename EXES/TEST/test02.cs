using System;
class test02
{
    static void Main(){
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var num = int.Parse(Console.ReadLine());

        string s1 = "Sailboats: ⛵";
        string s1_uni = "\ud83c\udf81"; // unicode code for s1
        string s2 = "☺";
        string s2_uni = "\u263A"; // unicode code for s2
        Console.WriteLine(s1);
        Console.WriteLine(s1_uni);
        Console.WriteLine(s2);
        Console.WriteLine(s2_uni);
    }
}