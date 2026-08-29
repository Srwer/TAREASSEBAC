using UnityEngine;

public class CreateEnableDisable : MonoBehaviour
{
    public GameObject prefabCubo;

    private void OnEnable()
    {
        Instantiate<GameObject>(prefabCubo);
    }

    private void OnDisable()
    {
        Instantiate<GameObject>(prefabCubo);
    }
}