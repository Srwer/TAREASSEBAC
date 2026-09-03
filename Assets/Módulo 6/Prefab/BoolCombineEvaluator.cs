using UnityEngine;

public class BoolCombineEvaluator : MonoBehaviour
{
    // Referencias al 3er y 4to cubo
    public BoolAndEvaluator go3;
    public BoolOrEvaluator go4;

    public bool resultadoCombinado;
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void FixedUpdate()
    {
        if (go3 != null && go4 != null)
        {
            // Combina los resultados de GO3 y GO4 con el operador AND (&&)
            resultadoCombinado = go3.resultadoAnd && go4.resultadoOr;

            // Blanco para true, Negro para false
            if (resultadoCombinado == true)
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