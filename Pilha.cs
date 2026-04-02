using System;

public class Pilha<T>
{
    private T[] elementos;             // Array para armazenar os elementos da pilha.
    private int tamanho;               // Variável para controlar o tamanho atual da pilha.
    private const int capacidadeInicial = 10; // Capacidade inicial da pilha.

    public Pilha()
    {
        elementos = new T[capacidadeInicial]; // Inicializa o array com a capacidade inicial.
        tamanho = 0;                          // Inicializa o tamanho da pilha como zero.
    }

    // Função para Empilhar um item na Pilha
    public void Push(T item)
    {
        if (tamanho == elementos.Length)
        {
            // Se a pilha estiver cheia, redimensiona o array para o dobro de sua capacidade atual.
            Array.Resize(ref elementos, elementos.Length * 2);
            // throw new InvalidOperationException("A pilha está cheia.");
        }

        elementos[tamanho] = item; // Adiciona o novo item no topo da pilha.
        tamanho++;                 // Aumenta o tamanho da pilha.
    }

    // Função para Desemmpilhar um item na Pilha
    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A pilha está vazia.");
        }

        tamanho--;             // Decrementa o tamanho para acessar o item no topo da pilha.
        T item = elementos[tamanho]; // Obtém o item no topo da pilha.
        elementos[tamanho] = default(T); // Define o valor padrão para evitar vazamentos de memória.
        return item;           // Retorna o item desempilhado.
    }

    // Função que retorna o Topo (último item) da Pilha 
    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("A pilha está vazia.");
        }

        return elementos[tamanho - 1]; // Retorna o item no topo da pilha sem removê-lo.
    }

    // Função que verifica se a Pilha está Vazia
    public bool IsEmpty()
    {
        return tamanho == 0; // Verifica se a pilha está vazia com base no tamanho.
    }

    // Função que retorna o tamanho (quantidade de itens) na Pilha
    public int Count()
    {
        return tamanho; // Retorna o número de elementos na pilha (tamanho atual).
    }

    // Função que reinicia a Pilha, eliminando todos os itens existentes
    public void Clear()
    {
        Array.Clear(elementos, 0, tamanho); // Limpa os elementos da pilha.
        tamanho = 0;                        // Redefine o tamanho para zero.
    }
}

class Program
{
    static void Main()
    {
        Pilha<int> pilha = new Pilha<int>(); // Cria uma instância da pilha de inteiros.

        pilha.Push(1); // Empilha o valor 1.
        Console.WriteLine("Empilhando valor " + 1);
        pilha.Push(2); // Empilha o valor 2.
        Console.WriteLine("Empilhando valor " + 2);
        pilha.Push(3); // Empilha o valor 3.
        Console.WriteLine("Empilhando valor " + 3);

        Console.WriteLine("Número de elementos na pilha: " + pilha.Count()); // Deve imprimir "Número de elementos na pilha: 3"

        Console.WriteLine("Topo da pilha: " + pilha.Peek()); // Deve imprimir "Topo da pilha: 3"

        Console.WriteLine("Desempilhando elementos:");
        while (!pilha.IsEmpty())
        {
            Console.WriteLine(pilha.Pop()); // Desempilha e imprime os elementos.
        }

        Console.WriteLine("Número de elementos na pilha: " + pilha.Count()); // Deve imprimir "Número de elementos na pilha: 0"
    }
}
