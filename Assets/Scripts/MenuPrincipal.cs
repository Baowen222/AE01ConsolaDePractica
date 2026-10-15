
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Jugar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Juego");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
