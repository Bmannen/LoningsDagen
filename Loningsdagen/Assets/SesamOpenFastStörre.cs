using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesamOpenFastStörre : MonoBehaviour
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
            transform.Rotate(0, 0, -90);
            transform.position = transform.position + transform.up * 2f + transform.right * -1f;
            transform.Rotate(0, 0, 90);
            dörrÖpen = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D door)
    {
        if (door.gameObject.name == "Player")
        {
            näraDörr = true;
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
