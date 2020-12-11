using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeleaJugador : MonoBehaviour
{
    public Animator animator;

    public Transform puntoAtaque;
    public LayerMask capaEnemigos;

    public float rangoAtaque = 0.5f;
    public int DañoAtaque = 20;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Attack();
        }
        /*
        if (Input.GetKeyDown(KeyCode.X))
        {
            Attack();
        }*/
    }
    void Attack()
    {
        //Poner animación de golpe
        animator.SetTrigger("golpe");

        //Detectar si el enemigo está cerca
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(puntoAtaque.position, rangoAtaque, capaEnemigos);

        //quitarle vida al enemigo
        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("ataqué al enemigo");
            enemy.GetComponent<Enemy>().SerAtacado(DañoAtaque);
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
