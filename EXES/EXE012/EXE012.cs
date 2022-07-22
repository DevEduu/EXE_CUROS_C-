//Faça um algoritmo que leia o sálario 
//de um funcionário e mostre seu novo salário, com 15% de aumento.
using System;
class EXE012{
    static void Main(){
        Console.Write("Informe seu Salário: ");
        double sal = Convert.ToDouble(Console.ReadLine());
        double salPlus = sal + (sal * (15.00 / 100.00));
        Console.Write("Seu salário com aumento de 15% será de : {0:c}", salPlus);
    }
}