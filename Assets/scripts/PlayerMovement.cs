using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

public class PlayerMovement : MonoBehaviour
{

    Animator animator;
    private float horizontal;
    private float speed = 3f;
    private float jumpingpower = 8f;
    private bool isFacingRight = true;

    private Vector2 movmentValue;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody2D>();
    }

    //public void OnMove(InputValue value)
    //{
    //    movmentValue = value.Get<Vector2>() * speed;
    //}

    // Update is called once per frame
    
    
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        Flip();

        if(Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingpower);
        }

        if(Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.05f);
        }


        //rb.AddRelativeForce(new Vector2(movmentValue.x * Time.deltaTime, 0f));

        //transform.Translate(movmentValue.x * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
       
        // if (Input.GetKey(KeyCode.S))
        //{
        //make him short lol
        //}
        // if (Input.GetKey(KeyCode.W))
        //{
        //gravity needed
        //}
    }

    /*  public void OnJump()
      {
          if(IsGrounded())
          { rb.velocity = new Vector2(rb.velocity.x, jumpingpower); }

      }*/

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    /*public void OnMove(InputValue value)
    {
        animator.SetBool("isMoving", true);
        if (value.isPressed)
        {
            animator.SetBool("isMoving", false);
        }

        // animator.SetBool("isMoving", true);
    }*/

    public bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
