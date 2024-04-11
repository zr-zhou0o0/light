using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tkeyTrigger4 : MonoBehaviour
{

 public int tkey4Active;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        Debug.Log("tkeytrigger4 is 1");
            
             tkey4Active = 1; 
             if(tkey4Active==1) Debug.Log("tkey4Active=1");
    }
}

    