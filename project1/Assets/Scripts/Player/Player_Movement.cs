using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player_Movement : MonoBehaviour
{
    //sets the speed of the movemnt for the player
    public float speed = 5f;

    //sets the max height so the player does not go off the screen
    public float min_Y, max_Y;

    public Rigidbody2D RigBdy;

    public float jumpSpeed = 8f;
    public Vector3 jump;
    //private bool isGrounded;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        RigBdy = GetComponent<Rigidbody2D>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        //isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

        //RigBdy.velocity =
        /*isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        direction = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * this.speed * Time.deltaTime;
            //transform.localScale = new Vector3(-1, 1f, 1f);
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * this.speed * Time.deltaTime;
            //transform.localScale = new Vector3(1, 1f, 1f);

        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            RigBdy.AddForce(jump * jumpSpeed, ForceMode2D.Impulse);
            isGrounded = false;
        }*/
    }

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * this.speed * Time.deltaTime;
            //transform.localScale = new Vector3(-0.5f, 1f, 1f);
            anim.SetBool("isMoving", true);


        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * this.speed * Time.deltaTime;
            //transform.localScale = new Vector3(0.5f, 1f, 1f);`
            anim.SetBool("isMoving", true);

        }


        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.up * this.speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.down * this.speed * Time.deltaTime;
        }


        /* if (this.transform.position != Vector3.right)
         {
             anim.SetBool("isMoving", true);
         }else
         {
             anim.SetBool("isMoving", false);
         }*/

        /*if (mousePos.x < screenPoint.x)
        {
            transform.localScale = new Vector3(-1, 1f, 1f);
        }*/

        /*if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            RigBdy.AddForce(jump * jumpSpeed, ForceMode.Impulse);
            isGrounded = false;
        }*/
    }



}