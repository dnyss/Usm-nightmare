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
}
