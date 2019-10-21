using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AinaRörelse : MonoBehaviour
{
    public Rigidbody2D rb;
    float xPos;
    float yPos;
    public float moveSpeed = 4f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + transform.up * moveSpeed * Time.fixedDeltaTime;

        yPos = transform.position.y;
        xPos = transform.position.x;

        if (yPos > 8 && rb.rotation < 10 && rb.rotation > -10)
        {
            
            rb.rotation = rb.rotation + 90;
            transform.position.Set(xPos, 8f, 0);
            
        }
        if (xPos < 6 && rb.rotation == 90)
        {
            rb.rotation = rb.rotation + 90;
            transform.position.Set(5f, yPos, 0);
        }
        if (yPos < 2 && rb.rotation == 180)
        {

            rb.rotation = rb.rotation + 90;
            transform.position.Set(xPos, 1f, 0);

        }
        if (xPos > 16 && rb.rotation == 270 && yPos < 8)
        {

            rb.rotation = rb.rotation - 270;
            transform.position.Set(16f, yPos, 0);

        }


    }
}
