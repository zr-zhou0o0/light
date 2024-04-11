using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tkey12l : MonoBehaviour
{
     public tkeyTrigger10 TkeyTrigger10;
     public float tkey12arrivetime=1.02f;
     public int tkey12music=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(TkeyTrigger10.tkey10Active==1
       &&Time.time>TkeyTrigger10.tkey10time+tkey12arrivetime){
        GetComponent<SpriteRenderer>().enabled = true;
        if(tkey12music==1)
       {GetComponent<AudioSource>().Play();
       tkey12music=0;}
       }
    }
}
