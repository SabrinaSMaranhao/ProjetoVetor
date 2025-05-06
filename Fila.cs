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
        private int tamanho = 0;  // Variável para armazenar o tamanho atual da fila

        public bool InserirNaFila(Clientes cliente) //metodo responsavel por inserir um cliente na fila, retorna true se for inserido
        {
            if (tamanho >= fila.Length) /*Verifica se a fila está cheia 
                                         Se 'tamanho' for igual 
                                         ou maior que o comprimento do vetor, a fila está cheia.*/
            {
                Console.WriteLine("Fila cheia!");
                return false;
            }

            if (cliente.ClientesPrioritarios) //Verifica se o cliente é prioritario
            {
                for (int i = tamanho; i > 0; i--) /* Joga todos os outros clientes uma posição pra frente, abre espaço p/ posição 0
                                                   Começa do final da fila atual até a posição 1 */
                {
                    fila[i] = fila[i - 1]; // coloca o cliente da posição anterior para a próxima.
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
            if (tamanho == 0) //verifica se a fila está vazia
            {
                Console.WriteLine("Fila vazia.");
                return; //encerra
            }

            Console.WriteLine("Fila atual:"); //Mostra todos os clientes na ordem da fila
            for (int i = 0; i < tamanho; i++) // Percorre a fila do início até o último cliente inserido (índice tamanho - 1).
            {
                // Exibe o número da posição na fila, o nome do cliente e se ele é prioritário ou comum.
                Console.WriteLine($"{i + 1}. {fila[i].Nome} - {(fila[i].ClientesPrioritarios ? "PRIORITÁRIO" : "Comum")}");
            }
        }

        public void AtenderCliente()
        {
            if (tamanho == 0) // Verifica se não há clientes na fila.
            {
                Console.WriteLine("Nenhum cliente para atender.");
                return;
            }

            Console.WriteLine($"Atendendo: {fila[0].Nome}"); //Mostra o cliente que está sendo atendido

            for (int i = 1; i < tamanho; i++) //Move os outros clientes uma posição pra trás
            {
                fila[i - 1] = fila[i]; // Cliente da posição i vai para a posição i-1
            }

            tamanho--; //diminui o tamanho da fila
        }


    }
}
