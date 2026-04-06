using System;

public class No<T>
{
    public T Dado;    // Armazena o dado (valor) do nó.
    public No<T> Proximo; // Referência para o próximo nó na lista.

    public No(T dado)
    {
        Dado = dado;  // Inicializa o nó com um dado e sem referência para o próximo nó.
        Proximo = null;
    }
}

public class ListaEncadeada<T>
{
    private No<T> cabeca; // Referência para o primeiro nó da lista.

    public ListaEncadeada()
    {
        cabeca = null;  // Inicializa a lista como vazia.
    }

    public void Adicionar(T dado)
    {
        No<T> novoNo = new No<T>(dado); // Cria um novo nó com o dado fornecido.

        if (cabeca == null)
        {
            cabeca = novoNo; // Se a lista está vazia, o novo nó se torna a cabeça da lista.
        }
        else
        {
            No<T> atual = cabeca;
            while (atual.Proximo != null)
            {
                atual = atual.Proximo; // Percorre a lista até encontrar o último nó.
            }
            atual.Proximo = novoNo; // Adiciona o novo nó como o próximo do último nó.
        }
    }

    public void Exibir()
    {
        No<T> atual = cabeca;
        while (atual != null)
        {
            Console.Write(atual.Dado + " -> "); // Exibe o dado do nó atual.
            atual = atual.Proximo;
        }
        Console.WriteLine("null"); // Indica o final da lista.
    }
}

class Program
{
    static void Main()
    {
        ListaEncadeada<int> lista = new ListaEncadeada<int>(); // Cria uma instância da lista encadeada de inteiros.

        lista.Adicionar(1); // Adiciona o valor 1 à lista.
        lista.Adicionar(2); // Adiciona o valor 2 à lista.
        lista.Adicionar(3); // Adiciona o valor 3 à lista.

        lista.Exibir(); // Deve imprimir "1 -> 2 -> 3 -> null"
    }
}
