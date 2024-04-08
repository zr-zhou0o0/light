using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tkeyTrigger7 : MonoBehaviour
{

 public int tkey7Active;
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
        Debug.Log("tkeytrigger7 is 1");
            
             tkey7Active = 1; 
             if(tkey7Active==1) Debug.Log("tkey7Active=1");
    }
}

    