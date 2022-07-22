// Escreva um programa que pegue 4 notas e mostrea sua 
// média e se esta aprovado ou não 
using System;
class Aula14{
    static void Main(){
        // incinando totas a variáveis
        double n1,n2,n3,n4,md=0.0;
        Console.WriteLine("SOFTWARE CACULAR MÉDIA");
        Console.Write("Informe a sua primeira nota: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Infome a segunda nota: ");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informe a terceira nota: ");
        n3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Informa a quanta e última nota: ");
        n4 = Convert.ToDouble(Console.ReadLine());

        md = (n1+n2+n3+n4)/4;

        Console.WriteLine("Sua média é de: {0}", md);
        if(md >= 6.0){
            Console.WriteLine("Você está aprovado!");
        }else if(md == 5.0){
            Console.Write("Você está de Recuperação");
        }else{
            Console.WriteLine("Você está Reprovado!");
        }
        
    }
}