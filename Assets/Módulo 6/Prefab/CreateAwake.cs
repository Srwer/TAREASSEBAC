using UnityEngine;

public class CreateAwake : MonoBehaviour
{
    public GameObject prefabCubo;

    private void Awake()
    {
        Instantiate<GameObject>(prefabCubo);
    }
}   