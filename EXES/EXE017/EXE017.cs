//Faça um programa que leia um ângulo qualquer e mostre na
// tela o valor do seno, casseno e tangente desse ângulo.
using System;
class EXE017{
    static void Main(){
        Console.Write("Informe o angulo: ");
        double ang = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Seno....: {0}", Math.Sin(ang));
        Console.WriteLine("Conseno...: {0}", Math.Cos(ang));
        Console.WriteLine("Tangente...: {0}",Math.Tan(ang));

    }
}