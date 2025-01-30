
using System;

namespace Well1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Você deseja comprar produto?(sim/nao)");
			string opcao1 = Console.ReadLine().ToLower();
			
			 if (opcao1 == "sim")
			
			{
			
			 	Console.WriteLine("Obrigado pela preferênia de compra!");
			 	Console.ReadLine();
			}
			 else
			{
			 	
			 	Console.WriteLine("Volte quando quiser realizar uma compra!");
				Console.ReadLine();
			 }
			 Console.WriteLine("Pressione qualquer botão para sair...");
			 Console.ReadKey(true);
		}
	}
}
