using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoJugador : MonoBehaviour
{
    private const int V = 10;
    public float jump;
    public float speed;
    private float move;
    private Rigidbody2D rb;

    public Animator animator;

    private GameObject healthbar;

    [SerializeField] private LayerMask platformLayerMask;
    private BoxCollider2D boxCollider2d;
    public Slider VidaSlider;
    

    private void Awake()
    {
        boxCollider2d = transform.GetComponent<BoxCollider2D>();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        healthbar = GameObject.Find("Barra de vida");
    }
    void Update()
    {
        move = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        //para la animacion de correr
        animator.SetFloat("Speed", move);

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
    
    }

//para revisar si está tocando el suelo o no:
    private bool IsGrounded(){
        
        float extraHeightText = 1f;
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider2d.bounds.center, boxCollider2d.bounds.size, 0f, Vector2.down, extraHeightText, platformLayerMask);
        return raycastHit.collider != null;
        }
        
    private void OnCollisionEnter2D(Collision2D collision)
    {
    if(collision.gameObject.tag == "EnemigoDebil"){
            VidaSlider.value -= 0.1f;
        }
    if (collision.gameObject.tag == "EnemigoMedio")
    {
        VidaSlider.value -= 0.2f;
    }

    if (collision.gameObject.tag == "EnemigoFinal")
    {
        VidaSlider.value -= 0.3f;
    }
        //Si el jugador muere
        if (VidaSlider.value <= 0)
    {
        Destroy(gameObject);
    }
    }
}