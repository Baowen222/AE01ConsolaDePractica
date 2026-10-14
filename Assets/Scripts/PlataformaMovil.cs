
using UnityEngine;

public class PlataformaMovil : MonoBehaviour
{
    public float velocidad = 2f;
    public float distancia = 3f;

    private Rigidbody2D rb;
    private Vector2 inicio;
    private int direccion = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        inicio = rb.position;
    }

    void FixedUpdate()
    {
        // Cambia direcion cuando limite
        if (rb.position.x >= inicio.x + distancia)
        {
            direccion = -1;
        }

        if (rb.position.x <= inicio.x - distancia)
        {
            direccion = 1;
        }

        // Mueve horizontal
        Vector2 nuevaPosicion = rb.position +
            Vector2.right * direccion * velocidad * Time.fixedDeltaTime;

        rb.MovePosition(nuevaPosicion);
    }
}
