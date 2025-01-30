
using System;

namespace Maior_que_Menor_que
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite o primeiro número:");
            int numero = int.Parse(Console.ReadLine());
           
            // Verifica se o número é maior que 10 e menor que 0
           if (numero > 10 || numero < 0)
          
            {
                Console.WriteLine("Número Inválido, digite um número entre 0 e 10"); //Caso o número seja maior que 10 e menor que 0 a mensagem será exibida
            }
            else
            {
                Console.WriteLine("Número Válido"); // Caso o número digitado estiver entre 0 e 10 a mensagem será exibidade
            }
            
            Console.WriteLine("Aperte qualquer botão para fechar...");
            Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
        }
    }
}
