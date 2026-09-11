using UnityEngine;

public class BloqueResistente : Bloque
{
    private void Start()
    {
        resistencia = 2;
        puntos = 20;
    }

    public override void RecibirGolpe()
    {
        base.RecibirGolpe();
        if (resistencia == 1)
        {
            GetComponent<Renderer>().material.color = Color.gray;
        }
    }
}