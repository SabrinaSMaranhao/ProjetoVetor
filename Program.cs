using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVetor
{
    internal class Program
    {   /* um vetor de objetos 'Clientes' com capacidade para armazenar até 10 clientes.
         A variável 'Fila' representa a fila, onde os clientes serão armazenados e organizados. */
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
                string opcao = Console.ReadLine(); //lê a opçao que o usuario digitou e armazena na variavel Opcao

                if (opcao.ToLower() == "q") //ToLower converte a letra pra minuscula, mesmo que o usuario digite maiuscula
                    break;

                switch (opcao) //switch para executar diferentes ações dependendo da opção escolhida pelo usuário
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

                        // Pergunta se o cliente é prioritário. Se a resposta for "S", define 'ClientesPrioritarios' como true
                        Console.Write("É prioritário? (S/N): ");
                        
                        string prioridade = Console.ReadLine();
                        novoCliente.ClientesPrioritarios = prioridade.ToUpper() == "S";

                        // Chama o método 'InserirNaFila' para adicionar o cliente na fila
                        filaBanco.InserirNaFila(novoCliente);
                        break;

                    case "2":
                        filaBanco.ListarFila();
                        break;

                    case "3":
                        filaBanco.AtenderCliente();
                        break;

                    case "q":
                        Console.WriteLine("Encerrando sistema...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }

            
        }
    }
}
