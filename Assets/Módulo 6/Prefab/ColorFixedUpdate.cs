using UnityEngine;

public class ColorFixedUpdate : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void FixedUpdate()
    {
        meshRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}