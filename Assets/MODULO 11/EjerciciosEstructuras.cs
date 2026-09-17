using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    private void Start()
    {
        List<int> listaAleatoria = GenerarListaAleatoria(5, 1, 100);
        Debug.Log("1) Lista Aleatoria: " + string.Join(", ", listaAleatoria));

        int[] arregloDesordenado = new int[] { 15, 3, 89, 42, 7 };
        int[] arregloOrdenado = OrdenarArregloDescendente(arregloDesordenado);
        Debug.Log("2) Arreglo Ordenado Descendente: " + string.Join(", ", arregloOrdenado));

        List<string> listaConDuplicados = new List<string> { "Manzana", "Pera", "Manzana", "Uva", "Pera" };
        HashSet<string> conjuntoSinDuplicados = ConvertirAHashSet(listaConDuplicados);
        Debug.Log("3) HashSet sin duplicados: " + string.Join(", ", conjuntoSinDuplicados));

        Stack<string> miPila = new Stack<string>();
        miPila.Push("Elemento 1");
        miPila.Push("Elemento 2");
        miPila.Push("Elemento 3");

        Debug.Log("4) Procesando Pila y Cola:");
        ProcesarPilaYCola(miPila);
    }

    public List<int> GenerarListaAleatoria(int tamano, int rangoInferior, int rangoSuperior)
    {
        List<int> lista = new List<int>();
        for (int i = 0; i < tamano; i++)
        {
            lista.Add(UnityEngine.Random.Range(rangoInferior, rangoSuperior + 1));
        }
        return lista;
    }

    public int[] OrdenarArregloDescendente(int[] arreglo)
    {
        int[] resultado = (int[])arreglo.Clone();
        Array.Sort(resultado);
        Array.Reverse(resultado);
        return resultado;
    }

    public HashSet<T> ConvertirAHashSet<T>(List<T> lista)
    {
        return new HashSet<T>(lista);
    }

    public void ProcesarPilaYCola(Stack<string> pilaEntrada)
    {
        Queue<string> colaDestino = new Queue<string>();

        Debug.Log("Elementos extraídos de la Pila (Pop) agregados a la Cola (Enqueue):");
        while (pilaEntrada.Count > 0)
        {
            string elementoVista = pilaEntrada.Peek();
            Debug.Log("Elemento en tope de Pila (Peek): " + elementoVista);

            string elementoDespilado = pilaEntrada.Pop();
            colaDestino.Enqueue(elementoDespilado);
        }

        Debug.Log("Elementos extraídos de la Cola (Dequeue):");
        while (colaDestino.Count > 0)
        {
            string elementoFrente = colaDestino.Peek();
            Debug.Log("Elemento al frente de la Cola (Peek): " + elementoFrente);

            string elementoDesencolado = colaDestino.Dequeue();
            Debug.Log("Elemento sacado de la Cola (Dequeue): " + elementoDesencolado);
        }
    }
}