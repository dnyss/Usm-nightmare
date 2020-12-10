using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : StateMachineBehaviour
{
    public int speed = 15;
    public float rangoAtaque = 3f;

    Transform jugador;
    Rigidbody2D rb;
    Enemy enemigo;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        jugador = GameObject.FindGameObjectWithTag("jugador").transform;
        rb = animator.GetComponent<Rigidbody2D>();
        enemigo = animator.GetComponent<Enemy>();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.GetComponent<Enemy>().LookAtPlayer();
        Vector2 target = new Vector2(jugador.position.x, rb.position.y);
        Vector2 nuevaPosicion = Vector2.MoveTowards(rb.position, target, speed * Time.deltaTime);
        rb.MovePosition(nuevaPosicion);

        if(Vector2.Distance(jugador.position, rb.position) <= rangoAtaque)
        {
            animator.SetTrigger("ataque");
        }

    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("ataque");
    }

}
