using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeleaJugador : MonoBehaviour
{
    public Animator animator;

    public Transform puntoAtaque;
    public float rangoAtaque = 0.5f;
    public LayerMask capaEnemigos;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Attack();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Attack();
        }
    }
    void Attack()
    {
        Debug.Log("atacando ");
        //Poner animación de golpe
        //animator.SetTrigger("golpe");

        //Detectar si el enemigo está cerca
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(puntoAtaque.position, rangoAtaque, capaEnemigos);

        //quitarle vida al enemigo
        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log(enemy.name);
        }
    }

    //Esto sirve solo para ver donde esta el area de ataque:
    void OnDrawGizmosSelected()
    {
        if (puntoAtaque == null)
            return;
        //Esto dibuja un círculo que tiene de centro la posición del punto de ataque y de radio el rango
        Gizmos.DrawWireSphere(puntoAtaque.position, rangoAtaque); 
    }
}
