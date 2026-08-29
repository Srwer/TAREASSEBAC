using UnityEngine;

public class CreateUpdate : MonoBehaviour
{
    public GameObject prefabCubo;

    private void Update()
    {
        Instantiate<GameObject>(prefabCubo);
    }
}