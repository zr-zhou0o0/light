using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twall12l : MonoBehaviour
{
    public twall12Trigger Twall12Trigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Twall12Trigger.tRay1Active==1){
        GetComponent<SpriteRenderer>().enabled = true;
      }  
    }
}
