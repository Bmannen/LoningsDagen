using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AinaSynfält : MonoBehaviour
{
    public Collider2D synfält;
    private bool skaSkjutas = false;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(skaSkjutas == true)
        {
            Debug.Log("Skjut");
        }
    }

    private void OnTriggerEnter2D(Collider2D synfält)
    {
        if (synfält.gameObject.name == "Player") 
        {
            Debug.Log("Skjut Ove");
        }
    }

    private void OnTriggerStay2D(Collider2D synfält)
    {
        
    }

    private void OnTriggerExit2D(Collider2D synfält)
    {
        skaSkjutas = false;
    }

}
