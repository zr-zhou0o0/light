using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tkey9l : MonoBehaviour
{
    public float tkey9arrivetime=2.27f;
    public tkeyTrigger8 TkeyTrigger8; 
    public tkeyTrigger9 TkeyTrigger9;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if( TkeyTrigger8.tkey8Active==1
       &&Time.time>TkeyTrigger8.tkey8time+tkey9arrivetime){
        GetComponent<SpriteRenderer>().enabled = true;
       } 
       
    }
}
