using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float VidaExtra = 0.2f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("jugador"))
        {
            Recoger();
        }
    }
    void Recoger()
    {
        GameObject jugador = GameObject.FindGameObjectWithTag("jugador");
        MovimientoJugador stats = jugador.GetComponent<MovimientoJugador> ();
        stats.VidaSlider.value += VidaExtra;
        Destroy(gameObject);
    }
}
