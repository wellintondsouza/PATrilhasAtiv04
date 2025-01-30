using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra:");
        string palavra = Console.ReadLine();

        // Verifica se a palavra não é vazia
        if (!string.IsNullOrWhiteSpace(palavra))
        {
            Console.WriteLine("A palavra não é vazia.");
        }
        else
        {
            Console.WriteLine("A palavra é vazia.");
        }

        Console.WriteLine("Aperte qualquer tecla para fechar...");
        Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
    }
}
