// Jogo de cartas Mofi
using System.Collections;

namespace Jogo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do jogador 1");
            string nome1 = Console.ReadLine();

            Console.WriteLine("Digite o nome do jogador 2 ou deixe em branco para jogar contra a maquina");
            string nome2 = Console.ReadLine();

            bool contraComputador = string.IsNullOrEmpty(nome2);

            if (contraComputador == true)
            {
                nome2 = "Máquina";
            }

            var Random = new Random();

            string vez = Random.Next(2) == 0 ? nome1 : nome2;





            Dictionary<string, int> energia = new Dictionary<string, int>();
            energia.Add(nome1, 10);
            energia.Add(nome2, 10);


            while (true)
            {
                Console.WriteLine("Energia do jogador 1 " + energia[nome1]);
                Console.WriteLine("Energia do jogador 2 " + energia[nome2]);

                Console.WriteLine("Vez de: " + vez);

                var gerador = new Random();

                string[] cartas = new string[3] { "Copas", "Espada", "Ouros" };
                string carta1 = cartas[gerador.Next(3)];
                string carta2 = cartas[gerador.Next(3)];
                string carta3 = cartas[gerador.Next(3)];


                Console.WriteLine("Cartas: " + carta1 + " " + carta2 + " " + carta3);
                Console.ReadLine();
                if (carta1 == carta2 && carta2 == carta3)
                {
                    Console.WriteLine("Nenhuma Carta diferente");
                }
                else
                {
                    Console.WriteLine("Cartas diferentes!  " + vez + " Perdeu uma energia");
                    energia[vez]--;
                }
                if (energia[vez] == 0) { Console.WriteLine(vez + " Perdeu a partida!"); break; }

                if (vez == nome1)
                {
                    vez = nome2;
                }
                else
                {
                    vez = nome1;
                }
                Console.ReadLine();
            }
        }
    }
}