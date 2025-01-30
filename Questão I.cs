using System;

namespace Well1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite seu nome");
			string nome = Console.ReadLine();
			
			 if (nome == "Wilson" || nome == "Glória" ) //Se o nome digitado for um desses dois...
			
			{
			 	Console.WriteLine("Olá! bem vindo de volta");
			 	Console.ReadLine();
			}
			 else
			{	
			 	Console.WriteLine("Acesso Negado! você não pode entrar no sistema!");
				Console.ReadLine();
			 }
			 Console.WriteLine("Pressione qualquer botão para sair...");
			 Console.ReadKey(true);
		}
	}
}
