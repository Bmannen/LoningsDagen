using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AinaSynfält : MonoBehaviour
{
    public Collider2D synfält;
    private bool skaSkjutas = false;
    double timer = 3;
    public Object player;
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(skaSkjutas == true)
        {
            timer = timer - Time.deltaTime;
            Debug.Log(timer);
            if(timer <= 0)
            {
                Destroy(player); 
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D synfält)
    {
        
    }

    private void OnTriggerStay2D(Collider2D synfält)
    {
        if (synfält.gameObject.name == "Player")
        {
            skaSkjutas = true;
            Debug.Log("Skjut Ove");
        }
        
    }

    private void OnTriggerExit2D(Collider2D synfält)
    {
        skaSkjutas = false;
    }

}
