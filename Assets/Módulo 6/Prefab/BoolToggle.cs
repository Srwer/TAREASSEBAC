using UnityEngine;

public class BoolToggle : MonoBehaviour
{
    // Variable booleana pública (Punto 4 de la consigna)
    public bool miEstado = false;

    private MeshRenderer meshRenderer;

    private void Awake()
    {
        // Guardamos la referencia del MeshRenderer del propio objeto
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void FixedUpdate()
    {
        // Invertimos el valor: si era false pasa a true, si era true pasa a false
        miEstado = !miEstado;

        // Si es verdadero (true) asigna Color.white, si es falso (false) asigna Color.black
        if (miEstado == true)
        {
            meshRenderer.material.color = Color.white;
        }
        else
        {
            meshRenderer.material.color = Color.black;
        }
    }
}