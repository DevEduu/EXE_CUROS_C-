/*Faça um algoritmo que leia o preço de
um produto e mostre seu novo preço, com 5% de desconto.*/
using System;
class EXE11{
    static void Main(){
        Console.Write("Infome o preço do produto: R$ ");
        double pr = double.Parse(Console.ReadLine());
        var ds = (pr - (pr * (5.0 / 100.00)));
        Console.Write("O Preço do produto com 5% de desconto será de {0:c}",ds);
    }
}