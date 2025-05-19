using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VidaJugador : MonoBehaviour
{
    public int vidas = 3;
    public TextMeshProUGUI textoVidas;
    public GameObject pantallaGameOver;

    void Start()
    {
        ActualizarTextoVidas();
        pantallaGameOver.SetActive(false);
    }

    public void PerderVida()
    {
        vidas--;
        ActualizarTextoVidas();

        if (vidas <= 0)
        {
            GameOver();
        }
    }

    void ActualizarTextoVidas()
    {
        textoVidas.text = "Vides: " + vidas;
    }

    void GameOver()
    {
       pantallaGameOver.SetActive (true);
        Time.timeScale = 0f; //esto pausa el juego
    }
    
    public void Reintentar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void IrAlMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
