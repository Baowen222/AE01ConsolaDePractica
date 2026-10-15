
using UnityEngine;

public class Pinchos : MonoBehaviour
{
    private IRespawn respawn;

    void Start()
    {
        respawn = GetComponent<IRespawn>();
    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Pincho"))
        {
            respawn.Reaparecer();
        }
    }
}
