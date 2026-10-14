
using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public Transform jugador;

    void LateUpdate()
    {
        if (jugador != null)
        {
            transform.position = new Vector3(
                jugador.position.x,
                transform.position.y,
                -10
            );
        }
    }
}
