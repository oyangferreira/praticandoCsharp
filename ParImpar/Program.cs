using System;

namespace Application
{
    class ParImpar
    {
        static void Main(string[] args)
        {
            double valor;

            Console.Write("Digite um número: ");
            valor = double.Parse(Console.ReadLine());

            if(valor % 2 == 0) {
                Console.WriteLine("Par");
            }
            else {
                Console.WriteLine("Ímpar");
            }

            Console.WriteLine("Versão da aplicação: 1.0"); 
        }
    }
}

