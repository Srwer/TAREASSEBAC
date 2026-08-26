using UnityEngine;

public class ColorUpdate : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        meshRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}