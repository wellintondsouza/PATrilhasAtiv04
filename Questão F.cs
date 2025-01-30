
using System;

namespace Well1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Você deseja adicionar açucar ou leite em seu café? (sim/nao):");
			 string opcao1 = Console.ReadLine().ToLower();
			
			 if (opcao1 == "sim")
			
			{
			
			 	Console.WriteLine("Café com adicional preparado!");
			 	Console.ReadLine();
			}
			 else
			{
			 	
			 	Console.WriteLine("Café SEM adicional preparado!");
				Console.ReadLine();
			 }
			 Console.WriteLine("Pressione qualquer botão para sair...");
			 Console.ReadKey(true);
		}
	}
}
