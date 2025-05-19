using UnityEngine;

public class DisparoAutomatico : MonoBehaviour
{
    public GameObject balaPrefab;
    public Transform puntoDisparo;

    public float intervalo = 0.5f;

    void Start()
    {
        InvokeRepeating(nameof(Disparar), 0f, intervalo);
    }

    void Disparar()
    {
        if (balaPrefab != null && puntoDisparo != null)
        {
            Instantiate(balaPrefab, puntoDisparo.position, puntoDisparo.rotation);
        }
    }

    /*void OnDestroy()
    {
        CancelInvoke(); // para evitar que siga intentando disparar si la nave muere
    }*/
}
