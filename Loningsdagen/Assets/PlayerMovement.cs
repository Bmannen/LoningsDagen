using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public float rotSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        //Input
    }

    private void FixedUpdate()
    {
        //Rörelse
        //Rotera åt vänster
        if(Input.GetKey(KeyCode.A)){
            rb.rotation = rb.rotation + rotSpeed;
        }
        //Rotera åt höger
        if (Input.GetKey(KeyCode.D))
        {
            rb.rotation = rb.rotation - rotSpeed;
        }
        //Framåt
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + transform.up * moveSpeed * Time.fixedDeltaTime;
        }

        //Bakåt
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + transform.up * -moveSpeed * 0.55f * Time.fixedDeltaTime;
        }


    }
}
