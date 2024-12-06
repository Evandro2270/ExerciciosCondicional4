using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                string[] vet = Console.ReadLine().Split(' ');
                int horaInicial = int.Parse(vet[0]);
                int horaFinal = int.Parse(vet[1]);

                int duracao;

                if (horaInicial < horaFinal)
                {
                    duracao = horaFinal - horaInicial; 
                }
                else
                {
                    duracao = 24 - horaInicial + horaFinal;
                }
                Console.WriteLine("O jogo durou " + duracao + " Hora(s)");

            }
        }
    }
}