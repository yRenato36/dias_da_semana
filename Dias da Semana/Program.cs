using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dias_da_Semana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia = 1;

            Console.WriteLine("Dias da Semana\n");
            for (int contador = 1; contador <= 7; contador++)
            {
                switch (contador)
                {
                    case 1:
                        Console.WriteLine("1 - Domingo");
                        break;
                    case 2:
                        Console.WriteLine("2 - Segunda-Feira");
                        break;
                    case 3:
                        Console.WriteLine("3 - Terça-Feira");
                        break;
                    case 4:
                        Console.WriteLine("4 - Quarta-Feira");
                        break;
                    case 5:
                        Console.WriteLine("5 - Quinta-Feira");
                        break;
                    case 6:
                        Console.WriteLine("6 - Sexta-Feira");
                        break;
                    case 7:
                        Console.WriteLine("7 - Sábado");
                        break;

                    default:
                        Console.WriteLine("Número não permitido");
                        break;
                }
            }
            Console.WriteLine(""); // variável vazia para pular linha
            Console.WriteLine("Digite um número para mostrar o dia da semana");
            dia = Convert.ToInt16(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Você escolheu Domingo");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu Segunda-Feira");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu Terça-Feira");
                    break;
                case 4:
                    Console.WriteLine("Você escolheu Quarta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Você escolheu Quinta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Você escolheu Sexta-Feira");
                    break;
                case 7:
                    Console.WriteLine("Você escolheu Sábado");
                    break;

                default:
                    Console.WriteLine("Número não permido");
                    break;
            };

            Console.ReadKey();

        }
    }
}
