using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skjutande : MonoBehaviour
{

    public bool harPistol = true; //Ändra när han plockar upp pistol
    public GameObject hylsa;
    GameObject skott;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (harPistol)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("Försöker skjuta");
                skott = Instantiate(hylsa, transform.position , transform.rotation);

            }
        }
    }
}
