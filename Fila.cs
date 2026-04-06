using System;
using System.Collections.Generic;

public class Fila<T>
{
    private LinkedList<T> elementos; // Usamos uma LinkedList para armazenar os elementos da fila.

    public Fila()
    {
        elementos = new LinkedList<T>(); // Inicializa a fila como uma nova LinkedList.
    }

    // Função que insere um item na Fila (Enfileirar)
    public void Enqueue(T item)
    {
        elementos.AddLast(item); // Adiciona o item no final da fila.
    }

    // Função que remove um item da Fila (Desenfileirar)
    public T Dequeue()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A fila está vazia.");
        }

        T item = elementos.First.Value; // Obtém o primeiro item da fila.
        elementos.RemoveFirst();        // Remove o primeiro item da fila.
        return item;                    // Retorna o item removido.
    }

    // Função que verifica e retorna o primeiro item da Fila
    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A fila está vazia.");
        }

        return elementos.First.Value; // Retorna o primeiro item da fila sem removê-lo.
    }

    // Função que verifica se a Fila está vazia
    public bool IsEmpty()
    {
        return elementos.Count == 0; // Verifica se a fila está vazia com base na contagem de elementos.
    }

    // Função que retorna o tamanho (quantidade de itens) da Fila
    public int Count()
    {
        return elementos.Count; // Retorna o número de elementos na fila.
    }

    // Função que reinicia a Fila, eliminando todos os itens existentes
    public void Clear()
    {
        elementos.Clear(); // Remove todos os elementos da fila.
    }
}

class Program
{
    static void Main()
    {
        Fila<int> fila = new Fila<int>(); // Cria uma instância da fila de inteiros.

        fila.Enqueue(1); // Adiciona o valor 1 à fila.
        fila.Enqueue(2); // Adiciona o valor 2 à fila.
        fila.Enqueue(3); // Adiciona o valor 3 à fila.

        Console.WriteLine("Primeiro da fila: " + fila.Peek()); // Deve imprimir "Primeiro da fila: 1"

        Console.WriteLine("Desenfileirando elementos:");
        while (!fila.IsEmpty())
        {
            Console.WriteLine(fila.Dequeue()); // Desenfileira e imprime os elementos.
        }

        Console.WriteLine("Número de elementos na fila: " + fila.Count()); // Deve imprimir "Número de elementos na fila: 0"
    }
}
