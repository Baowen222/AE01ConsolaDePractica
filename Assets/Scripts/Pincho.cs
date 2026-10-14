
using UnityEngine;

public class Pinchos : MonoBehaviour
{
    private Vector3 posicionInicial;

    void Start()
    {
        posicionInicial = transform.position;
    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Pincho"))
        {
            transform.position = posicionInicial;

            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.linearVelocity = Vector2.zero;
        }
    }
}
