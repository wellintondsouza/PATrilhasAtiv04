using System;

namespace Well1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Você é assinante de um serviço de stream?(sim/nao):");
			 string stream = Console.ReadLine().ToLower();
			
			Console.WriteLine("Você já assistiu a série Viking's?(sim/nao):");
			 string serie = Console.ReadLine().ToLower();
			
			 if (stream == "sim" && serie == "sim")
			
			{
			
			 	Console.WriteLine("Ótimo, agora você pode assistir à nova temporada!");
			 	Console.ReadLine();
			}
			 else
			{
			 	
			 	Console.WriteLine("Você não pode assistir se não tiver um serviço de stream, mas se tiver pode ver caso queira!");
				Console.ReadLine();
			 }
			 Console.WriteLine("Aperte qualquer tecla para sair...");
			 Console.ReadKey(true);
		}
	}
}
