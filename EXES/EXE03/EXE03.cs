// Crie um programa que leia dois número a soma entre eles.
using System;
class EXE03{
    static void Main(){
        Console.Write("Informe o primeiro valor: ");
        String n1 = Console.ReadLine();
        int num1 = Int32.Parse(n1);
        Console.Write("Informe o segundo valor: ");
        String n2 = Console.ReadLine();
        int num2 = Int32.Parse(n2);

        Console.Write("A Soma de {0} + {1} = {2}",num1, num2, (num1+num2));
    }
}