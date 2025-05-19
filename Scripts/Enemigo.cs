using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float velocidad = 2f;

    void Update()
    {
        transform.Translate(Vector2.down * velocidad * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bala"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Jugador")) // La nave del jugador
        {
            VidaJugador vida = collision.GetComponent<VidaJugador>();
            if (vida != null)
            {
                vida.PerderVida();
            }

            Destroy(gameObject); // destruir el enemigo al tocar al jugador
        }

    }

}
