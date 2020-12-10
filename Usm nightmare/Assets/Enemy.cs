using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int VidaMaxima = 100;
    int VidaActual;
    public Animator animator;

    void Start()
    {
        VidaActual = VidaMaxima;
    }

    public void SerAtacado(int daño)
    {
        VidaActual -= daño;
        animator.SetTrigger("herido");

        if(VidaActual <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        //deshabilitar enemigo
        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;

    }

    //esto es para dar vuelta la imagen si el jugador esta a la izquierda
    public bool isFlipped = false;

    public void LookAtPlayer()
    {
        GameObject jugador = GameObject.FindGameObjectWithTag("jugador");
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

        if (transform.position.x > jugador.transform.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = false;
        }
        else if (transform.position.x <= jugador.transform.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = true;
        }
    }
    //ataque enemigo
    public Transform puntoAtaque;
    public LayerMask capajugadores;

    public float rangoAtaque = 5f;
    public int DañoAtaque = 20;

    void EnemyAttack()
    {
        //Detectar si el enemigo está cerca
        Collider2D[] hitJugador = Physics2D.OverlapCircleAll(puntoAtaque.position, rangoAtaque, capajugadores);

        //quitarle vida al enemigo
        foreach (Collider2D player in hitJugador)
        {
            //player.GetComponent<MovimientoJugador>().SerAtacado(DañoAtaque);
        }
    }

    //Esto sirve solo para ver donde esta el area de ataque:
    void OnDrawGizmosSelected()
    {
        if (puntoAtaque == null)
            return;
        Gizmos.DrawWireSphere(puntoAtaque.position, rangoAtaque);
    }


}
