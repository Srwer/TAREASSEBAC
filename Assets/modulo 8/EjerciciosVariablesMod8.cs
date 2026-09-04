using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    private int contadorEntero = 0;
    private float acumuladorFloat = 1.0f;

    private int contadorParImpar = 0;
    private MeshRenderer meshRenderer;

    [SerializeField] private string palabraColor = "Rojo";

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        float valorA = 15.75f;
        float valorB = 4.25f;
        int resultadoCasteado = (int)(valorA + valorB);
        Debug.Log($"Parte 1 - Ej 2: {resultadoCasteado}");

        AplicarColorPorPalabra(palabraColor);

        float numeroLargo = 3.14159265f;
        string numeroFormateado = numeroLargo.ToString("F4");
        Debug.Log($"Parte 1 - Ej 5: {numeroFormateado}");

        string nombreCompleto = "Samuel Herrera Lopez";

        string primerNombreSub = nombreCompleto.Substring(0, 6);
        string primerApellidoSub = nombreCompleto.Substring(7, 7);
        string segundoApellidoSub = nombreCompleto.Substring(15);
        Debug.Log($"Parte 1 - Ej 6 (Substring): {primerNombreSub} | {primerApellidoSub} | {segundoApellidoSub}");

        string[] nombresLista = nombreCompleto.Split(' ');
        Debug.Log($"Parte 1 - Ej 6 (Split): {string.Join(", ", nombresLista)}");

        string strMiles1 = "1500";
        string strMiles2 = "2500";

        if (int.TryParse(strMiles1, out int num1) && int.TryParse(strMiles2, out int num2))
        {
            int sumaMiles = num1 + num2;
            Debug.Log($"Parte 2 - Ej 1: {sumaMiles}");
        }

        string oracionBase = "Hola Mundo";
        string caracteresPares = "";

        for (int i = 0; i < oracionBase.Length; i++)
        {
            if (i % 2 == 0)
            {
                caracteresPares += oracionBase[i] + (i < oracionBase.Length - 2 ? "," : "");
            }
        }
        Debug.Log($"Parte 2 - Ej 2: {caracteresPares}");

        string oracionLarga = "Hola Mundo desde Unity";
        string sinPrimerosCinco = oracionLarga.Substring(5);
        Debug.Log($"Parte 2 - Ej 3: {sinPrimerosCinco}");
    }

    private void Update()
    {
        contadorEntero++;
    }

    private void FixedUpdate()
    {
        acumuladorFloat *= 1.01f;

        contadorParImpar++;
        if (meshRenderer != null)
        {
            if (contadorParImpar % 2 == 0)
            {
                meshRenderer.material.color = Color.white;
            }
            else
            {
                meshRenderer.material.color = Color.black;
            }
        }
    }

    private void AplicarColorPorPalabra(string palabra)
    {
        if (meshRenderer == null) return;

        switch (palabra.ToLower())
        {
            case "rojo":
                meshRenderer.material.color = Color.red;
                break;
            case "azul":
                meshRenderer.material.color = Color.blue;
                break;
            case "verde":
                meshRenderer.material.color = Color.green;
                break;
            default:
                meshRenderer.material.color = Color.gray;
                break;
        }
    }
}