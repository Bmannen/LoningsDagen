using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyKulaFlyg : MonoBehaviour
{

    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.up * Time.fixedDeltaTime * bulletSpeed;
    }

    private void OnCollisionStay2D(Collision2D kula)
    {
        if (kula.gameObject.tag == "Aina")
        {
            Destroy(kula.gameObject);  
        }
        if (kula.gameObject.name != "Player")
        {
            Destroy(this.gameObject);
        }
        

    }
}
