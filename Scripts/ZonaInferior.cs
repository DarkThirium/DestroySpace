using UnityEngine;

public class ZonaInferior : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo"))
        {
            // Intenta encontrar el objeto de la nave para quitarle vida
            GameObject jugador = GameObject.FindGameObjectWithTag("Jugador");
            if (jugador != null)
            {
                VidaJugador vida = jugador.GetComponent<VidaJugador>();
                if (vida != null)
                {
                    vida.PerderVida();
                }
            }

            Destroy(other.gameObject); // Destruir el enemigo
        }
    }
}
