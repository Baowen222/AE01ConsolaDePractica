
using UnityEngine;

public class Meta : MonoBehaviour
{
    public GameObject panelVictoria;

    void Start()
    {
        Time.timeScale = 1f;
        panelVictoria.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Jugador"))
        {
            Debug.Log("Gano");

            panelVictoria.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
