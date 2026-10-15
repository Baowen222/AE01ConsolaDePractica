
using UnityEngine;

public class RespawnJugador : MonoBehaviour, IRespawn
{
    private Vector3 puntoRespawn;
    private Rigidbody2D rb;

    void Start()
    {
        // Guarda posicion inicial
        puntoRespawn = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    public void Reaparecer()
    {
        // Devolver el jugador al respawn
        transform.position = puntoRespawn;
        rb.linearVelocity = Vector2.zero;
    }

    public void GuardarCheckpoint(Vector3 posicion)
    {
        // Guardar la nueva posicion
        puntoRespawn = posicion;
    }
}
