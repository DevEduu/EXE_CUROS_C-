using System;
// Faça um programa que leia um 
// número inteiro qualquer e mostre na tela a sua Tabuada
class EXE08 {
    static void Main(){
        Console.WriteLine("====TABUADA===");
        Console.Write("Informe um número: ");
        var num = int.Parse(Console.ReadLine());

        Console.WriteLine("1  X {0} = {1} ", num, (num*1));
        Console.WriteLine("2  X {0} = {1} ", num, (num*2));
        Console.WriteLine("3  X {0} = {1} ", num, (num*3));
        Console.WriteLine("4  X {0} = {1} ", num, (num*4));
        Console.WriteLine("5  X {0} = {1} ", num, (num*5));
        Console.WriteLine("6  X {0} = {1} ", num, (num*6));
        Console.WriteLine("7  X {0} = {1} ", num, (num*7));
        Console.WriteLine("8  X {0} = {1} ", num, (num*8));
        Console.WriteLine("9  X {0} = {1} ", num, (num*9));
        Console.WriteLine("10 X {0} = {1} ", num, (num*10));

    }
}