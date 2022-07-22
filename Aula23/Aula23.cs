// Metodos utilizado em Vetores e Matrizis
using System;
class Aula23
{
    static void Main(){
        Console.Clear();

        int[] vetor1 = new int[5];
        int[] vetor2= new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};

        Random random = new Random();
        for (int i = 0; i < (vetor1.Length); i++)
        {
            vetor1[i]=random.Next(50);
        }

        Console.WriteLine("Elementos do Vetor1");
        foreach (int i in vetor1)
        {
            Console.WriteLine(i);
        }

        // BinarySearch(array, valor)
        Console.WriteLine("BinarySearch");
        int procurar=36;
        int pos=Array.BinarySearch(vetor1, procurar);
        Console.WriteLine("Valor {0} está na posição {1}",procurar, pos);
        for (int i = 0; i < 30; i++)
        {
            Console.Write("-");
        }

        //Copy(Origem, destino, quantidade0)
        
    }
}