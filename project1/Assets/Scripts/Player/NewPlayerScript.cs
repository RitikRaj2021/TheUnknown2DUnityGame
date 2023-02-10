using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerScript : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 5f;
    private float direction = 0f;
    private Rigidbody2D astroPlayer;


    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;



    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        astroPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        direction = Input.GetAxis("Horizontal");

        //Move Right
        if (direction > 0f)
        {
            astroPlayer.velocity = new Vector2(direction * speed, astroPlayer.velocity.y);
            //anim.SetBool("isMoving", true);
            //transform.localScale = new Vector2(1f, 1f);
        }
        //Move Left
        else if (direction < 0f)
        {
            astroPlayer.velocity = new Vector2(direction * speed, astroPlayer.velocity.y);
            //anim.SetBool("isMoving", false);
            //transform.localScale = new Vector2(1f, 1f);
        }
        else
        {
            astroPlayer.velocity = new Vector2(0, astroPlayer.velocity.y);

        }
        //Jump
        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            astroPlayer.velocity = new Vector2(astroPlayer.velocity.x, jumpSpeed);

        }

        if (astroPlayer.velocity == Vector2.zero)
        {
            anim.SetBool("isMoving", false);
        }
        else
        {
            anim.SetBool("isMoving", true);
        }

    }
}
