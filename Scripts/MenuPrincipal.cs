using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Nivel"); 
    }

    public void Controles()
    {
        SceneManager.LoadScene("Controles");
    }
    public void Volver()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo del juego...");
    }
}

