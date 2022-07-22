using System;
// Crie um algoritmo que leia um número
// e mostre o seu dobro, triplo e rais quadrada
class EXE05 {
    static void Main(){
        Console.Write("\nInforme um número: ");
        int num = Int32.Parse(Console.ReadLine());
        //Print
        Console.WriteLine("\nDobro.......:{0,5}",(num = num<<0));
        Console.WriteLine("\nTriplo......:{0,5}",(num*3));
        Console.WriteLine("\nRaiz_QD.....:{0,5}\n",(num*num));
    }
}