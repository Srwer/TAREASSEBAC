using UnityEngine;

public class BoolOrEvaluator : MonoBehaviour
{
    // Referencias a los dos primeros cubos
    public BoolToggle go1;
    public BoolToggle go2;

    public bool resultadoOr;
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void FixedUpdate()
    {
        if (go1 != null && go2 != null)
        {
            // Evalúa el operador OR (||)
            resultadoOr = go1.miEstado || go2.miEstado;

            // Blanco para true, Negro para false
            if (resultadoOr == true)
            {
                meshRenderer.material.color = Color.white;
            }
            else
            {
                meshRenderer.material.color = Color.black;
            }
        }
    }
}