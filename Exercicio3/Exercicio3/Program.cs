using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Uma empresa de um MMORPG quer fazer um programa para descobrir alguns dados sobre os personagens dos jogadores. A empresa deseja saber: 
 * a) média de Gold dos personagens; b) média do número de montarias; c) maior valor de Gold; 
 * d) percentual de personagens com Gold até 100. O programa deverá ficar lendo dados de personagens até que haja a entrada de uma quantidade de gold negativa. 
 * (Use o comando WHILE) [Feito em Aula]
 */

namespace Exercicio3
{
    class Jogador
    {
        public int gold;
        public int montaria;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Jogador> listaDeJog = new List<Jogador>();
            Jogador j = new Jogador();
            int gold = -1;

            do
            {
                Console.WriteLine("Informe seu Gold");
                j.gold = Convert.ToInt32(Console.ReadLine());
                gold = j.gold;
                if (gold < 0)
                    break;
                Console.WriteLine("Informe quantidade de montarias");
                j.montaria = Convert.ToInt32(Console.ReadLine());
                listaDeJog.Add(j);
            } while (!(gold < 0));
        }
    }
}
