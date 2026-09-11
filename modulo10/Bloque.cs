using UnityEngine;

public class Bloque : MonoBehaviour
{
    [SerializeField] protected int puntos = 10;
    [SerializeField] protected int resistencia = 1;

    public virtual void RecibirGolpe()
    {
        resistencia--;
        if (resistencia <= 0)
        {
            DestruirBloque();
        }
    }

    protected virtual void DestruirBloque()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bola"))
        {
            RecibirGolpe();
        }
    }
}   