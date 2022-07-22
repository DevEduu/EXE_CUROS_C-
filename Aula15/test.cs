using System;
class menu{
    static void Main(){
        char resposta;
        inicio:
        Console.Clear();
        Console.WriteLine("Opções ");
        Console.WriteLine("Moto [M]");
        Console.WriteLine("Carro [C]");
        Console.WriteLine("ônibus [O]");
        resposta =  char.Parse(Console.ReadLine());
        Console.Write("\nVocê escolheu a opção [{0}]", resposta);

        Console.WriteLine("\nDeseja executar novamente? [s / n]");
        resposta = char.Parse(Console.ReadLine());

        if (resposta == 's' || resposta == 'S'){
            goto inicio;
        }else{
            Console.Clear();
            Console.Write("Programa finalizado!");
        }
        
       

    }
}