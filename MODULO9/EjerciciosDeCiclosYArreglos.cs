using UnityEngine;

public class EjerciciosDeCiclosYArreglos : MonoBehaviour
{
    private void Start()
    {
        int tamano = 5;
        int[] arr1 = new int[tamano];
        int[] arr2 = new int[tamano];
        int[] arr3 = new int[tamano];

        for (int i = 0; i < tamano; i++)
        {
            arr1[i] = Random.Range(1, 10);
            arr2[i] = Random.Range(1, 10);
            arr3[i] = arr1[i] + arr2[i];
            Debug.Log($"arr3[{i}] = {arr1[i]} + {arr2[i]} = {arr3[i]}");
        }

        string[] palabras = new string[] { "Aprender", "a", "programar", "en", "Unity", "es", "genial" };
        string oracionCompleta = "";

        foreach (string palabra in palabras)
        {
            oracionCompleta += palabra + " ";
        }
        Debug.Log($"Oración concatenada: {oracionCompleta.Trim()}");

        int[,] matrizA = new int[2, 3] {
            { 2, 4, 6 },
            { 1, 3, 5 }
        };

        int[] vectorB = new int[3] { 3, 2, 1 };
        int[] resultado = new int[2];

        for (int i = 0; i < 2; i++)
        {
            int suma = 0;
            for (int j = 0; j < 3; j++)
            {
                suma += matrizA[i, j] * vectorB[j];
            }
            resultado[i] = suma;
            Debug.Log($"Resultado matriz * vector [{i}]: {resultado[i]}");
        }
    }
}