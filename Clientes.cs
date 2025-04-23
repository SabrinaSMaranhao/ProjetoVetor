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
        protected string CPF;
        private string Senha;
        Clientes[] user = new Clientes[10];


        public void cadastrar()
        {
           
            Console.WriteLine(" Digite seu nome:");
            this.Nome = Console.ReadLine();

            Console.WriteLine(" Digite seu Email:");
            this.Email = Console.ReadLine();

            Console.WriteLine(" Digite seu CPF:");
            this.CPF = Console.ReadLine();

            Console.WriteLine(" Digite uma senha:");
            this.Senha = Console.ReadLine();
        }
        
        


    }
}
