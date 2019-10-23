using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour 
{
    public Collider2D hand;
    private bool interactable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D hand)
    {

    }

    private void OnTriggerStay2D(Collider2D hand)
    {
        if (hand.gameObject.tag == "Aina")
        {
            interactable = true;
            Debug.Log("Here's Jonny");
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(hand.gameObject);
            }
        }

    }

    private void OnTriggerExit2D(Collider2D hand)
    {
        interactable = false;
    }

}
