using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    public Animator animator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("jugador"))
        {
            animator.SetBool("guardar", true);
        }
    }
}
