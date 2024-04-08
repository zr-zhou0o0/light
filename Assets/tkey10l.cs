using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tkey10l : MonoBehaviour
{
    public  tkeyTrigger9 TkeyTrigger9;
    public float tkey10arrivetime=2.07f;
    public int tkey10mode=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TkeyTrigger9.tkey9Active==1
        &&Time.time>TkeyTrigger9.tkey9time+tkey10arrivetime){
            GetComponent<SpriteRenderer>().enabled=true;
            tkey10mode=1;
        }
    }
}
