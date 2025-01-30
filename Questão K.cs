
using System;

namespace Projeto1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Você é um Robô? (sim/nao):");
            string resposta = Console.ReadLine().ToLower();
           
          
           if (resposta == "nao")
          
            {
                Console.WriteLine("Por favor, prove que você não é um Robô!"); 
            }
            else
            {
            	Console.WriteLine("Não é permitido a entrada de um robô! ");
            }
            
            Console.WriteLine("Aperte qualquer botão para fechar...");
            Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
        }
    }
}
