using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_simulado_samaris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qtde;
            int maior = 0;
            int total = 0;
            int num = 0;
            int contador = 0; // int n = 0; no da professora

            Console.Write("Digite a quantidade de entradas: ");
            qtde = Convert.ToInt32(Console.ReadLine());
                       
            
            while (contador < qtde)
            {
                Console.Write("Digite um número inteiro: ");
                num = Convert.ToInt32(Console.ReadLine());
                total = total + num;
                contador++;

                if (num > maior)
                {
                    maior = num;
                }
            }

            Console.Write("Total: " + total + "\nMaior valor: " + maior);
            Console.ReadLine();

        }
    }
}
