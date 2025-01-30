using System;

namespace Well1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite a sua idade:");
			int idade = int.Parse (Console.ReadLine());
			
			Console.WriteLine("Você tem Carteira de motorista? (sim/não)");
			 string resposta = Console.ReadLine().ToLower();
			
			 if (idade >= 18 && resposta == "sim")
			
			{
			
			 	Console.WriteLine("Você pode dirigir!");
			 	Console.ReadLine();
			}
			 else
			{
			 	
			 	Console.WriteLine("Você não pode dirigir!");
				Console.ReadLine();
			 }
			 Console.WriteLine("Aperte qualquer botão para sair...");
			 Console.ReadKey(true);
		}
	}
}
