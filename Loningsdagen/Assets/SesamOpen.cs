using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesamOpen : MonoBehaviour
{
    public Collider2D door;
    private bool näraDörr = false;
    private bool dörrÖpen = false;
    private bool harAnvänts = false;
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
            transform.Rotate(0, 0, -80);
            transform.position = transform.position + transform.up * 0.85f + transform.right * -0.4f;
            dörrÖpen = true;
            harAnvänts = true;
        }

        if (näraDörr == true && Input.GetKeyDown(KeyCode.E) && dörrÖpen == true && harAnvänts == false)
        {
            transform.position = transform.position - transform.up * 0.85f - transform.right * -0.4f;
            transform.Rotate(0, 0, 80);
            
            dörrÖpen = false;
        }

        harAnvänts = false;

    }

    private void OnTriggerEnter2D(Collider2D door)
    {
        if (door.gameObject.name == "Player")
        {
            näraDörr = true;
            Debug.Log("Vid väggen");
        }
        
    }

    private void OnTriggerStay2D(Collider2D door)
    {
        
    }

    private void OnTriggerExit2D(Collider2D door)
    {
        näraDörr = false;
    }
}
