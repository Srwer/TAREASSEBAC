using UnityEngine;

public class BloqueEspecial : Bloque
{
    private void Start()
    {
        resistencia = 1;
        puntos = 50;
    }

    protected override void DestruirBloque()
    {
        Debug.Log($"¡Bloque Especial destruido! Puntos otorgados: {puntos}");
        base.DestruirBloque();
    }
}