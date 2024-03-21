using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Vector2 movmentValue;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        movmentValue = value.Get<Vector2>() * speed;
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddRelativeForce(new Vector2(movmentValue.x * Time.deltaTime, 0f));

        transform.Translate(movmentValue.x * Time.deltaTime, 0, 0);

        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(speed * Time.deltaTime,0,0);
        //}
        //  if (Input.GetKey(KeyCode.A))
        //{
         //   transform.Translate(-speed * Time.deltaTime,0,0);
        //}
         // if (Input.GetKey(KeyCode.S))
        //{
          //make him short lol
        //}
         // if (Input.GetKey(KeyCode.W))
        //{
            //gravity needed
        //}
    }
}
