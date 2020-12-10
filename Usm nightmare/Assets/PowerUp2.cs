using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp2 : MonoBehaviour
{
    public int FuerzaExtra = 20;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("jugador"))
        {
            Recoger();
        }
    }
    void Recoger()
    {
        /*GameObject jugadore = GameObject.FindGameObjectWithTag("jugador");
        PeleaJugador stats = jugadore.GetComponent<PeleaJugador>();
        stats.DañoAtaque += FuerzaExtra;*/
        Debug.Log("recogido");
        Destroy(gameObject);
    }
}
