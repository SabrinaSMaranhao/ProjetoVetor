using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVetor
{
    internal class Fila : Clientes
    {
        private Clientes[] fila = new Clientes[10]; //Vetor
        private int tamanho = 0;

       public bool InserirNaFila(Clientes cliente)
        {
            if (tamanho >= fila.Length) //Verifica se a fila está cheia
            {
                Console.WriteLine("Fila cheia!");
                return false;
            }

            if (cliente.ClientesPrioritarios) //Verifica se o cliente é prioritario
            {
                for (int i = tamanho; i > 0; i--) //Joga todos os outros clientes uma posição pra frente
                {
                    fila[i] = fila[i - 1];
                }
                fila[0] = cliente; //coloca o prioritario na posição 0 do vetor
            }
            else
            {
                fila[tamanho] = cliente; //se for comum, entra no final da fila
            }

            tamanho++; //Aumenta o tamanho da fila
            return true;
        }

        public void ListarFila()
        {
            if (tamanho == 0)
            {
                Console.WriteLine("Fila vazia.");
                return;
            }

            Console.WriteLine("Fila atual:"); //Mostra todos os clientes na ordem da fila
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

            Console.WriteLine($"Atendendo: {fila[0].Nome}"); //Mostra o cliente que está sendo atendido

            for (int i = 1; i < tamanho; i++) //Move os outros clientes uma posição pra trás
            {
                fila[i - 1] = fila[i];
            }

            tamanho--; //diminui o tamanho da fila
        }


    }
}
