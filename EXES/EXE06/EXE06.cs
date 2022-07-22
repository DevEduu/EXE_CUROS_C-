using System;
// Crie um algoritmo que leia um número e 
// mostre o seu dobro, triplo e rais quadrada.
class EXE06 {
    static void Main(){
        Console.WriteLine("Calcular Média:");
        Console.Write("Primeira nota: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Segunda nota: ");
        double n2 = Convert.ToDouble(Console.ReadLine());

        double med = (n1 + n2) / 2;

        Console.Write("A Média da sua nota foi de {0}", med);
    }
}