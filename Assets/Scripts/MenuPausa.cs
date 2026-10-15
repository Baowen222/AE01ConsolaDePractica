
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject panelPausa;
    public GameObject botonContinuar;

    private bool pausado = false;



    void Update()
    {
        // Detecta el boton start del mando
        if (Gamepad.current != null &&
            Gamepad.current.startButton.wasPressedThisFrame)
        {
            if (pausado)
                Continuar();
            else if (Time.timeScale != 0f)
                Pausar();
        }
    }



    public void Pausar()
    {
        pausado = true;
        Time.timeScale = 0f;
        panelPausa.SetActive(true);

        
        EventSystem.current.SetSelectedGameObject(botonContinuar);
    }

    public void Continuar()
    {
        pausado = false;
        Time.timeScale = 1f;
        panelPausa.SetActive(false);
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Juego");
    }

    public void VolverMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    void OnEnable()
    {
        InputSystem.onDeviceChange += CambioMando;
    }

    void OnDisable()
    {
        InputSystem.onDeviceChange -= CambioMando;
    }

    void CambioMando(InputDevice dispositivo, InputDeviceChange cambio)
    {
        // Si se desconecta mando se pausa
        if (dispositivo is Gamepad &&
            cambio == InputDeviceChange.Removed)
        {
            if (Time.timeScale != 0f)
            {
                Pausar();
            }
        }
    }


    void OnApplicationFocus(bool tieneFoco)
    {
        Debug.Log("Foco de la ventana: " + tieneFoco);

        if (!tieneFoco)
        {
            Pausar();
        }
    }


}
