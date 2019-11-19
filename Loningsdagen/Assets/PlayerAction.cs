﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour 
{
    public Collider2D handen;
    private bool interactable;
    public bool jagHarStålarna = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D hand)
    {
        
    }

    private void OnCollisionStay2D(Collision2D hand)
    {
        if (hand.gameObject.tag == "Aina")
        {
            interactable = true;
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(hand.gameObject);
            }
        }
        if (hand.gameObject.tag == "Pengar" && jagHarStålarna == false)
        {
            interactable = true;

            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(hand.gameObject);
                jagHarStålarna = true;
            }
        }

    }

    private void OnCollisionExit2D(Collision2D hand)
    {
        interactable = false;
    }

}
