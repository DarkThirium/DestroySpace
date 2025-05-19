using UnityEngine;

public class SpawneadorEnemigos : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public float intervalo = 2f;
    public float ancho = 8f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemigo), 1f, intervalo);
    }

    void SpawnEnemigo()
    {
        float ancho = 8f;
        Vector2 posicion = new Vector2(Random.Range(-ancho, ancho), transform.position.y);
        Instantiate(enemigoPrefab, posicion, Quaternion.identity);
    }

}
