using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MovimientoJugador : MonoBehaviour
{
    private const int V = 10;
    public float jump;
    public float speed;
    private float move;
    private Rigidbody2D rb;
    private bool facingRight;

    public GameObject GameOver;

    public Animator animator;

    private GameObject healthbar;

    public LayerMask platformLayerMask;
    public LayerMask platformLayerMask2;
    private BoxCollider2D boxCollider2d;
    public Slider VidaSlider;

    private GameMaster gm;

    private void Awake()
    {
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    private void Start()
    {
        //Para los checkpoints:
        gm = GameObject.FindGameObjectWithTag("gm").GetComponent<GameMaster>();
        transform.position = gm.lastCheckPointPos;
        //
        rb = GetComponent<Rigidbody2D>();

        healthbar = GameObject.Find("Barra de vida");

        facingRight = true;
    }
    void Update()
    {
        move = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        //para la animacion de correr
        animator.SetFloat("Speed", Mathf.Abs(move));

        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
        //Para la animacion de salto
        if (IsGrounded())
        {   //si esta tocando el suelo el salto es falso
            animator.SetBool("isJumping", false);
        }
        else
        {   //si no esta tocando el suelo el salto es verdadero
            animator.SetBool("isJumping", true);
        }
        Flip(move);

    }
    //Dar vuelta la animación si está mirando a la izquierda
    private void Flip(float move)
    {
        if(move > 0 && !facingRight ||move<0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }

    //para revisar si está tocando el suelo o no:
    private bool IsGrounded(){
        
        float extraHeightText = 1f;
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, extraHeightText, platformLayerMask);
        RaycastHit2D raycastHit2 = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, extraHeightText, platformLayerMask2);
        return (raycastHit.collider != null || raycastHit2.collider !=null);
        }
        
    //Daño del personaje
    private void OnCollisionEnter2D(Collision2D collision)
    {
    if (collision.gameObject.tag == "EnemigoDebil"){
        animator.SetTrigger("herido");
        VidaSlider.value -= 0.05f;
        }
    if (collision.gameObject.tag == "EnemigoMedio")
    {
        animator.SetTrigger("herido");
        VidaSlider.value -= 0.1f;
        }

    if (collision.gameObject.tag == "EnemigoFinal")
    {
        animator.SetTrigger("herido");
        VidaSlider.value -= 0.2f;
    }
    if (collision.gameObject.tag == "pincho")
    {
        animator.SetTrigger("herido");
        VidaSlider.value -= 0.1f;
    }
    if (collision.gameObject.tag == "zoom")
    {
        animator.SetTrigger("herido");
        VidaSlider.value -= 9.9f;
    }
    //Si el jugador muere

    if (VidaSlider.value <= 0)
    {
            Time.timeScale = 0f;
            GameOver.SetActive(true);
    }
    }
}