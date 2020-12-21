using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    private GameMaster gm;

    public Animator animator;
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("gm").GetComponent<GameMaster>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("jugador"))
        {
            gm.lastCheckPointPos = transform.position;
            animator.SetBool("guardar", true);
        }
    }
}
