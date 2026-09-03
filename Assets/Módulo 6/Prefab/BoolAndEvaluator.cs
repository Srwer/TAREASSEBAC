using UnityEngine;

public class BoolAndEvaluator : MonoBehaviour
{

    public BoolToggle objeto1;
    public BoolToggle objeto2;


    public bool resultadoAnd;

    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void FixedUpdate()
    {

        if (objeto1 != null && objeto2 != null)
        {
       
            resultadoAnd = objeto1.miEstado && objeto2.miEstado;

     
            if (resultadoAnd == true)
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