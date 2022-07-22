//Um profressor quer sortear um dos seus quatro alunos 
//para apagar o quadro. Faça um programa que ajuda ele,
//lendo o nome deles e escrevendo o nome do escolhido.

using System;
class EXE018{
    static void Main(){
        inicio:
        Console.Clear();
        Random randNum = new Random();
        
        String[] alunos = {"Fernando","Alice","Gloria", "Ricardo"};
        Console.Write("O aluno(a) sorteada foi: {0,7}",alunos[randNum.Next(0,4)]);

        Console.WriteLine("\nDeseja gerar novamente? [s / n]");
        char res = char.Parse(Console.ReadLine());
        if (res == 's' || res == 'S'){
            goto inicio;
        }else{
            Console.Clear();
            Console.Write("Programa finalizado!");
        }


    }
}