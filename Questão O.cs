using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Você não deseja cancelar uma operação?");
        string palavra = Console.ReadLine(); 

        // Verifica se a palavra não é vazia
        if (palavra == "nao") 
        {
            Console.WriteLine("Por Favor, confime o cancelamento da operação.");
        }
        else
        {
            Console.WriteLine("Ok, bem vindo!");
        }

        Console.WriteLine("Aperte qualquer tecla para fechar...");
        Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
    }
}
