using System;

namespace Well1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Você tem um diploma de ensino superior?(sim/nao)");
			 string diploma = Console.ReadLine().ToLower();
			
			Console.WriteLine("Quantos anos você tem? (precisa ter 21 anos ou mais)");
			int idade = int.Parse (Console.ReadLine());
			
			 if (diploma == "sim" && idade >= 21)
			
			{
			
			 	Console.WriteLine("Parabéns, você está qualificado para a vaga!");
			 	Console.ReadLine();
			}
			 else
			{
			 	
			 	Console.WriteLine("Você não tem 21 anos, você não está qualificado para vaga!");
				Console.ReadLine();
			 }
			 Console.WriteLine("Aperte qualquer botão para sair...");
			 Console.ReadKey(true);
		}
	}
}
