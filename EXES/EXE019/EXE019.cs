// O mesmo professor do desafio anterior quer sortear a ordem de apresentação 
// de trabalhos dos alunos. Faça um programa que leia o nome dos quatro alunos 
// e mostre a ordem sorteada.

using System;
class EXE019{
    static void Main(){
     
        Console.Clear();
        string[] alunos = new string[4]; 

        for(int i = 0; i <=3; i++){
            Console.Write("Informe o {0}º aluno: ",i+1);
            alunos[i] = Console.ReadLine();

        }
        int[] num = new int[4];
        int validate=0;
        Random randInt = new Random();
        for(int x = 0; x <= 3; x++){
            
            validate = randInt.Next(0,4);
            
            if (validate == num[x]){
                x++;
            }else{
                num[x] = randInt.Next(0,4);
            }
        }
        for(int y = 0; y<= 4; y++){
            Console.WriteLine("{0}º = {1}", y, alunos[num[y]]);
        }
    }
  
}
