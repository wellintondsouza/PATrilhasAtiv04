using System;

namespace Well1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Escolha por qual número deseja dividir: (3 ou 5)");
			int numero = int.Parse(Console.ReadLine());
			
			
			if (numero % 3 == 0 || numero % 5 == 0)
			
			{
				Console.WriteLine(" O número é divisível por 3 e por 5!");
			 	Console.ReadLine();
			}
			 else
			{
			 	
			 	Console.WriteLine(" O número NÃO é divisível por 3 e por 5!");
				Console.ReadLine();
			 }
			 Console.WriteLine("Aperte qualquer botão para sair...");
			 Console.ReadKey(true);
		}
	}
}
