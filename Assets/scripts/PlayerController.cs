using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f);
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }
}
