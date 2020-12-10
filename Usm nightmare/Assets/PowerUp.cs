using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int VidaExtra = 20;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("jugador"))
        {
            Recoger();
        }
    }
    void Recoger()
    {
        //PlayerStats stats = jugador.GetComponent<nombre del script donde este la vida> ();
        //stats.nombre variable de vida += VidaExtra;
        Debug.Log("recogido");
        Destroy(gameObject);
    }
}
