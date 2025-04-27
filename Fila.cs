using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVetor
{
    internal class Fila : Clientes
    {
        private Clientes[] fila = new Clientes[10];
        private int tamanho = 0;

       public bool InserirNaFila(Clientes cliente)
        {
            if (tamanho >= fila.Length)
            {
                Console.WriteLine("Fila cheia!");
                return false;
            }

            if (cliente.ClientesPrioritarios)
            {
                for (int i = tamanho; i > 0; i--)
                {
                    fila[i] = fila[i - 1];
                }
                fila[0] = cliente;
            }
            else
            {
                fila[tamanho] = cliente;
            }

            tamanho++;
            return true;
        }

        public void ListarFila()
        {
            if (tamanho == 0)
            {
                Console.WriteLine("Fila vazia.");
                return;
            }

            Console.WriteLine("Fila atual:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"{i + 1}. {fila[i].Nome} - {(fila[i].ClientesPrioritarios ? "PRIORITÁRIO" : "Comum")}");
            }
        }

        public void AtenderCliente()
        {
            if (tamanho == 0)
            {
                Console.WriteLine("Nenhum cliente para atender.");
                return;
            }

            Console.WriteLine($"Atendendo: {fila[0].Nome}");

            for (int i = 1; i < tamanho; i++)
            {
                fila[i - 1] = fila[i];
            }

            tamanho--;
        }


    }
}
