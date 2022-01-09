using System;


namespace ProjetoElevadorTeste
{
    internal class Program
    {		
		public static void Main(string[] args)
		{
			string mensagem = "";
            Model.Elevador elevador = new Model.Elevador();

			//---------------------------------------
			// Alimenta quantidade maxima de andares
			//---------------------------------------
			elevador.Inicializar(1);

			//------------------------------------------
			// Limpa o console pois  segunda chamada do
			// metodo inicializar remonta o cabeçalho
			//------------------------------------------
			Console.Clear();

			//-------------------------------------------
			// Alimenta quantidade maxima de passageiros
			//-------------------------------------------
			elevador.Inicializar(2);


		Inicio:

			Console.Clear();

			Console.WriteLine(" -----------------------------------");
			Console.WriteLine(" | Bem vindo ao Ocean Office Tower |");
			Console.WriteLine(" ----------------------------------- \n");

			Console.WriteLine(" Total de Andares:       " + elevador.MaxAndar + "\n Capacidade Passageiros: " + elevador.MaxPassageiros + "\n Andar atual:            " + elevador.AndarAtual + "\n Qtd Passageiro:         " + elevador.QtdPassageiros);

			//------------------------------------------------------------
			// Apresenta mensagem para o usuário definir o que acontecerá
			//------------------------------------------------------------
			Console.WriteLine("\n Digite uma opção:\n  1.Entrar\n  2.Sair\n  3.Subir\n  4.Descer\n  5.Fechar o Programa*\n");

			//--------------------------------------------------
			// Tratamento para apresentação de mensagem de erro
			//--------------------------------------------------
			if (mensagem != "")
			{
				Console.Beep();
				Console.WriteLine(mensagem);
				mensagem = "";
			}

			string escolha = Console.ReadLine();

			//------------------------------------------------------
			// Estrura de tratamento da opção digitada pelo usuário
			//------------------------------------------------------
			switch (escolha)
			{
				case "1":
					if (!elevador.Entrar())
					{
						mensagem = "*Quantidade máxima de passageiros atingida. Por favor digite outra opção.";
					}
					break;
				case "2":
					if (!elevador.Sair())
					{
						mensagem = "*Não há passageiros dentro do elevador. Por favor digite outra opção.";
					}
					break;
				case "3":
					if (!elevador.Subir())
					{
						mensagem = "*O elevador está no ultimo pavimento. Por favor digite outra opção.";
					}
					break;
				case "4":
					if (!elevador.Descer())
					{
						mensagem = "*O elevador está no piso terreo. Por favor digite outra opção.";
					}
					break;
				case "5":
					Console.WriteLine("Obrigado por utilizar o Elevador. Até mais!");
					Environment.Exit(0);
					break;
				default:					
					mensagem = "*Opção inválida. Por favor digite uma das opções apresentadas.";
					break;
			}
			goto Inicio;
		}
	}
}
