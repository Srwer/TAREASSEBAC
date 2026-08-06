using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // 1. Primera función del Game Loop
    private void Awake()
    {
        Debug.Log("Este es un mensaje normal (Debug.Log) enviado desde Awake.");
    }

    // 2. Segunda función del Game Loop
    private void Start()
    {
        Debug.LogWarning("Este es un mensaje de advertencia (Debug.LogWarning) enviado desde Start.");
    }

    // 3. Tercera función del Game Loop
    private void Update()
    {
        Debug.LogError("Este es un mensaje de error (Debug.LogError) enviado desde Update.");
    }
}