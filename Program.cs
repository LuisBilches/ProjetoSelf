﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolleyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] jogadores = new int[4]; 
            int[] timeA = new int[2];
            int[] timeB = new int[2];

            PopulaVetor(jogadores);
            OrdenaVetor(jogadores);
            EquilibraTimes(timeA, timeB, jogadores);

            Console.WriteLine("Jogadores");
            jogadores.ToList().ForEach(Console.WriteLine);
            Console.WriteLine();


            Console.WriteLine("Time A:");
            timeA.ToList().ForEach(Console.WriteLine);
            Console.WriteLine();

            Console.WriteLine("Time B:");
            timeB.ToList().ForEach(Console.WriteLine);

            Console.ReadLine();

        }

        //Metodo para popular vetor de jogadores com números aleatórios.
        public static void PopulaVetor(int[] jogadores)
        {

            Random numAleatorio = new Random();

            for (int x = 0 ; x < jogadores.Length; x++)
            {
                jogadores[x] = numAleatorio.Next(0, 11);
            }

        }

        //Metodo para ordenar o nível dos jogadores de fomra crescente.
        public static void OrdenaVetor(int[] jogadores)
        {       
            Array.Sort(jogadores);
        }

        //Metodo que divide os times de forma mais equilibrada possível
        public static void EquilibraTimes(int[] timeA, int[] timeB, int[] jogadores)
        {
            timeA[0] = jogadores[0];
            timeA[1] = jogadores[3];

            timeB[0] = jogadores[1];
            timeB[1] = jogadores[2];
        }
    }
}