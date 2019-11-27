using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkenStjälPengarna : MonoBehaviour
{

    public Collider2D avlämningsområde;
    public GameObject player;
    public GameObject pengaPåse;
    GameObject släpptPåse;
    public int pengaPåsar = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D avlämningsområde)
    {
        if(player.GetComponent<PlayerAction>().jagHarStålarna == true)
        {
            player.GetComponent<PlayerAction>().jagHarStålarna = false;
            pengaPåsar++;
            släpptPåse = Instantiate(pengaPåse, transform.position, transform.rotation);
        }
    }
}
