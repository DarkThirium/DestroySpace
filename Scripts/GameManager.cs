using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;

    public int puntuacion = 0;
    public TextMeshProUGUI textoPuntuacion;

    void Awake()
    {
        // Singleton: solo una instancia de GameManager
        if (instancia == null)
        {
            instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SumarPuntos(int puntos)
    {
        puntuacion += puntos;
        textoPuntuacion.text = "Puntuación: " + puntuacion;
    }
}
