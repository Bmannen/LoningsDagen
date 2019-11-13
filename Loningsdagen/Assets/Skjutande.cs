using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skjutande : MonoBehaviour
{

    public bool harPistol = true; //Ändra när han plockar upp pistol
    public int antalSkott = 3;
    public GameObject hylsa;
    GameObject skott;
    float inteMaskingevär;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (harPistol && antalSkott > 0)
        {
            if (inteMaskingevär > 0)
            {
                inteMaskingevär = inteMaskingevär - Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.Space) && inteMaskingevär <= 0)
            {
                inteMaskingevär = 1;
                skott = Instantiate(hylsa, transform.position + transform.up * 0.5f, transform.rotation);
                antalSkott = antalSkott - 1;
            }
        }
    }
}
