// Jockey pow
//✊🖐✌️
using System;
using System.Threading;
class JokePow{
    static void Main(){
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        bool cont = true;
        
        while(cont){
            Console.Clear();//Limpar console
            int esco = 0;
            string[] emojis = new string[3];
            emojis[0] = "✊";
            emojis[1] = "🖐";
            emojis[2] = "✌️";
            Random randInt = new Random();
            
            for(int c = 0 ;c <= (emojis.Length)-1; c++){
                Thread.Sleep(560);
                Console.Write("{0,3} ",emojis[c]);
            }
            Console.WriteLine("\n🌟 Jockey pow ✨");

            for(int i = 0; i <= (emojis.Length) - 1 ; i++){
                Console.WriteLine("{0}  == [{1}]", emojis[i], i);
            }

            esco = int.Parse(Console.ReadLine());


            int pc = randInt.Next(1,3);

            if (pc == esco)
            {
                Console.WriteLine("PC {0}  X VOCÊ {1}  = EMPATE!", emojis[pc], emojis[esco]);
            }else if(esco == 0 & pc == 2 || esco == 2 & pc == 1 || esco == 1 & pc == 0){
                Console.WriteLine("PC {0} X VOCÊ {1} = 🥳 Você vencel 🤩 🏅", pc, esco);
            }else {
                Console.WriteLine("PC {0} X VOCÊ {1} = PC Venceu!🤖🏅", pc, esco );
            }
            Console.WriteLine("Jogar novamente? [s / n]");
            char conts = char.Parse(Console.ReadLine()); 
            if(conts == 'n' || conts == 'N'){
                cont = false;
            }
        }
        Console.Clear();
        Console.WriteLine("🎮 Game finalizado! 👋");
    }
}