using System;

namespace Projeto1
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Você é membro inativo de um club?");
            string resposta = Console.ReadLine().ToLower();
           
          
           if (resposta == "nao")
          
            {
                Console.WriteLine("Por favor, atualize sua inscrição para continuar usufruindo dos benefícios do clube."); 
            }
            else
            {
            	Console.WriteLine("Que bom.");
            }
            
            Console.WriteLine("Aperte qualquer botão para fechar...");
            Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
        }
    }
}
