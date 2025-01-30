using System;

namespace Well1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Você quer comprar um carro novo?(sim/não)");
			 string opcao1 = Console.ReadLine().ToLower();
			
			Console.WriteLine("Você tem dinheiro suficiente para isso? (sim/não)");
			 string opcao2 = Console.ReadLine().ToLower();
			
			 if (opcao1 == "sim" && opcao2 == "sim")
			
			{
			
			 	Console.WriteLine("Parabéns, você pode comprar um carro novo.");
			 	Console.ReadLine();
			}
			 else
			{
			 	
			 	Console.WriteLine("Você não pode comprar o carro, ou ainda não quer, quando quiser estamos disponíveis para te ajudar!");
				Console.ReadLine();
			 }
			 Console.WriteLine("Aperte qualquer botão para sair...");
			 Console.ReadKey(true);
		}
	}
}
