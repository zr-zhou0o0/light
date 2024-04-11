using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tkey11l : MonoBehaviour
{
    public tkeyTrigger8 TkeyTrigger8; 
    public float tkey11ArriveTime=1.02f;
    public int tkey11music=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TkeyTrigger8.tkey8Active==1
        &&Time.time>TkeyTrigger8.tkey8time+tkey11ArriveTime)
       { GetComponent<SpriteRenderer>().enabled = true;
        if(tkey11music==1)
        { GetComponent<AudioSource>().Play();
        tkey11music=0;}
       }
    }
}
