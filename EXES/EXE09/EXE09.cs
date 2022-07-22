// Crie um programa que leia quando dinheiro uma pessoa tem
// na carteira e mostre quantos Dólares ela pode comprar.
// Cosidere US$1.00 = R$4,75
using System;

class EXE09 {
    static void Main(){
        Console.Write("Informe quantos reais você tem: R$ ");
        double rs = Convert.ToDouble(Console.ReadLine());

        Console.Write("Com {0:c} da pra comprar $ {1:n}", rs, (rs/4.75));

    }
}