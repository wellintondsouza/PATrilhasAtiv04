
using System;

namespace Projeto1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());
           
          
           if (numero != 0)
          
            {
                Console.WriteLine("O número é diferente de 0!"); 
            }
            else
            {
            	Console.WriteLine("O número é igual a zero.");
            }
            
            Console.WriteLine("Aperte qualquer botão para fechar...");
            Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
        }
    }
}
