using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tkey8l : MonoBehaviour
{
    public float tkey8ArriveTime=1.02f;
    public twall12Trigger Twall12Trigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Twall12Trigger. tRay1Active==1
       &&Time.time>Twall12Trigger.twall12time+tkey8ArriveTime){
 GetComponent<SpriteRenderer>().enabled = true;
       } 
    }
}
