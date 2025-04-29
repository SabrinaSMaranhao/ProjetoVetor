using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVetor
{
    internal class Program
    {
       public Clientes[] Fila = new Clientes[10];
    
        static void Main(string[] args)
        {



         

            Fila filaBanco = new Fila();

            while (true) //laço infinito pra manter o menu
            {
                Console.WriteLine("\n===== MENU ===");
                Console.WriteLine("1. Cadastrar cliente");
                Console.WriteLine("2. Listar fila");
                Console.WriteLine("3. Atender próximo cliente");
                Console.WriteLine("Digite 'q' para sair");
                Console.Write("Opção:\n");
                string opcao = Console.ReadLine(); //lê a opçao que o usuario digitou

                if (opcao.ToLower() == "q") //ToLower converte a letra pra minuscula, mesmo que o usuario digite maiuscula
                    break;

                switch (opcao)
                {
                    case "1":
                        Clientes novoCliente = new Clientes();

                        Console.Write("Nome: ");
                        novoCliente.Nome = Console.ReadLine();

                        Console.Write("Idade: ");
                        novoCliente.Idade = int.Parse(Console.ReadLine());

                        Console.Write("Email: ");
                        novoCliente.Email = Console.ReadLine();

                        Console.Write("CPF: ");
                        novoCliente.DefinirCPF(Console.ReadLine());

                        Console.Write("Senha: ");
                        novoCliente.DefinirSenha(Console.ReadLine());

                        Console.Write("É prioritário? (S/N): ");
                        
                        string prioridade = Console.ReadLine();
                        novoCliente.ClientesPrioritarios = prioridade.ToUpper() == "S";

                        filaBanco.InserirNaFila(novoCliente);
                        break;

                    case "2":
                        filaBanco.ListarFila();
                        break;

                    case "3":
                        filaBanco.AtenderCliente();
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }

            Console.WriteLine("Encerrando sistema...");
        }
    }
}
