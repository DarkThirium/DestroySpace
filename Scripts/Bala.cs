using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad = 10f;
   
    void Update()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo"))
        {
            Destroy(other.gameObject); // destruye el enemigo
            Destroy(gameObject);       // destruye la bala

            // Sumar puntos al destruir al enemigo
            GameManager.instancia.SumarPuntos(1);
        }
    }
}
