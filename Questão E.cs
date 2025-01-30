using System;

namespace Well1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            // Lê a quantidade de caracteres com o comando Length
            int quantidadeCaracter = nome.Length;
            //Da o acesso a entrada de Acesso caso os requerimentos sejam atendidos
            if (quantidadeCaracter >= 3 && idade >= 18)
            {
                Console.WriteLine("Acesso Permitido!");
            }
            else
            {
                Console.WriteLine("Acesso Negado!");
            }

            Console.WriteLine("Aperte qualquer tecla para sair...");
            Console.ReadKey(true);
        }
    }
