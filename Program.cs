using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a distancia percorrida: ");
            double distancia = double.Parse(Console.ReadLine());

            Console.Write("Informe o tempo gasto para percorrer " + distancia + " Km: ");
            double tempo = double.Parse(Console.ReadLine());

            double velocidadeMedia = distancia / tempo;

            Console.Write("A velocidade média do percurso foi de: " + velocidadeMedia + " Km/h.");

            Console.ReadKey();
        }
    }
}
