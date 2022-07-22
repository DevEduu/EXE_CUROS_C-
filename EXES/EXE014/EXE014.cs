/* Escreva um programa que pergunte a quantidade de km percorrido 
por um carro alugado e a quantidade de dias pelas quais ele foi alugado.
Calcule o preço a pagar, sabendo que o carro custa R$60 por dia e R$0,15 por Km rodado.*/
using System;
class EXE014{
    static void Main(){
        Console.Write("Quantos Km você pecorrel?: ");
        double km = Convert.ToDouble(Console.ReadLine());
        Console.Write("Quantos dias decorridos?: ");
        int ds = Convert.ToInt16(Console.ReadLine());
        
        double valorTotal = (km * 0.15) + (ds * 60.0);

        Console.Write("Valor total a pagar será de: {0:c}.", valorTotal);
    }
}