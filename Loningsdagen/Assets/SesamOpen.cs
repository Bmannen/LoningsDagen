﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesamOpen : MonoBehaviour
{
    public Collider2D door;
    private bool näraDörr = false;
    private bool dörrÖpen = false;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (näraDörr == true && Input.GetKeyDown(KeyCode.E) && dörrÖpen == false)
        {
            transform.Rotate(0, 0, 90);
            dörrÖpen = true;
        }

        if (näraDörr == true && Input.GetKeyDown(KeyCode.E) && dörrÖpen == true)
        {
            transform.Rotate(0, 0, 270);
        }

    }

    private void OnTriggerEnter2D(Collider2D door)
    {
        näraDörr = true;
    }

    private void OnTriggerStay2D(Collider2D door)
    {
        
    }

    private void OnTriggerExit2D(Collider2D door)
    {
        näraDörr = false;
    }
}
