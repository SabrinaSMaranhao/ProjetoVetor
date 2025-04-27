using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVetor
{
    internal class Clientes
    {
        public string Nome { get; set; }
        public bool ClientesPrioritarios { get; set; }
        public string Email;
        public int Idade;
        protected string CPF { get; set; }
        private string Senha;

        public void DefinirSenha(string senha) => Senha = senha;
        public void DefinirCPF(string cpf) => CPF = cpf;


        public void cadastrar()
        {
           
            Console.WriteLine(" Digite seu nome:");
            this.Nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            this.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite seu Email:");
            this.Email = Console.ReadLine();

            Console.WriteLine(" Digite seu CPF:");
            this.CPF = Console.ReadLine();

            Console.WriteLine(" Digite uma senha:");
            this.Senha = Console.ReadLine();

            Console.WriteLine("Cadastro Realizado!");
        }
        
        


    }
}
