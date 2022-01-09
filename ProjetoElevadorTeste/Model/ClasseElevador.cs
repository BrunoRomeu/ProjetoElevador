using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevadorTeste.Model
{
	public class Elevador
	{
		public int AndarAtual;
		public int QtdPassageiros;
		public int MaxPassageiros;
		public int MaxAndar;

		//--------------------------------------------------------------------------------------
		// Inicializar: deve receber como parâmetros a capacidade do elevador e o total de
		// andares no prédio (os elevadores sempre começam no térreo e vazio)
		//--------------------------------------------------------------------------------------
		public void Inicializar(int opcao)
		{
			int QtdAndares;
			int QtdPessoas;
			string InputAndares;
			string InputPessoas;
			string mensagem = "";

		//------------------------------
		// Input de andares/passageiros
		//------------------------------

		Controle1:

			Console.WriteLine(" -----------------------------------");
			Console.WriteLine(" | Bem vindo ao Ocean Office Tower |");
			Console.WriteLine(" ----------------------------------- \n");

			if (opcao == 1)
			{
				Console.WriteLine("Quantos andares o elevador terá a partir do 0?");
			}
			else
			{
				Console.WriteLine("Quantos passageiros o elevador comportará?");
			}

			if (mensagem != "")
			{
				Console.Beep();
				Console.WriteLine(mensagem);
				mensagem = "";
			}

			if (opcao == 1)
			{
				InputAndares = Console.ReadLine();

				if (int.TryParse(InputAndares, out QtdAndares) && QtdAndares > 0)
				{
					this.MaxAndar = QtdAndares;
				}
				else
				{
					mensagem = "*Valor inválido de andares. Por favor digite um número positivo e acima de 0";
					Console.Clear();
					goto Controle1;
				}

			}
			else
			{
				InputPessoas = Console.ReadLine();

				if (int.TryParse(InputPessoas, out QtdPessoas) && QtdPessoas > 0)
				{
					this.MaxPassageiros = QtdPessoas;
				}
				else
				{
					mensagem = "*Valor inválido de passageiros. Por favor digite um número positivo e acima de 0";
					Console.Clear();
					goto Controle1;
				}
			}

		}

		//--------------------------------------------------------
		// Entrar: método para acrescentar uma pessoa no elevador
		//--------------------------------------------------------
		public bool Entrar()
		{
			bool valido = true;

			if (this.QtdPassageiros < MaxPassageiros)
			{
				this.QtdPassageiros++;
			}
			else
			{
				valido = false;
			}
			return valido;
		}

		//--------------------------------------------------
		// Sair: método para remover uma pessoa do elevador 
		//--------------------------------------------------
		public bool Sair()
		{
			bool valido = true;
			if (this.QtdPassageiros > 0)
			{
				this.QtdPassageiros--;
			}
			else
			{
				valido = false;
			}
			return valido;
		}

		//----------------------------------
		// Subir: Método para subi um andar
		//----------------------------------
		public bool Subir()
		{
			bool valido = true;
			if (this.AndarAtual < MaxAndar)
			{
				this.AndarAtual++;
			}
			else
			{
				valido = false;
			}
			return valido;
		}

		//-------------------------------------
		// Descer: Método para descer um andar
		//-------------------------------------
		public bool Descer()
		{
			bool valido = true;
			if (this.AndarAtual > 0)
			{
				this.AndarAtual--;
			}
			else
			{
				valido = false;
			}
			return valido;
		}
	}
}
