
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Jugador"))
        {
            // Buscamos el script de respawn del jugador
            RespawnJugador respawn = otro.GetComponent<RespawnJugador>();

            if (respawn != null)
            {
                // Guardamos la posición del checkpoint
                respawn.GuardarCheckpoint(transform.position);

                Debug.Log("Checkpoint guardado");
            }
        }
    }
}
