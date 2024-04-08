using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tkeyTrigger5 : MonoBehaviour
{

 public int tkey5Active;
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
        Debug.Log("tkeytrigger5 is 1");
            
             tkey5Active = 1; 
             if(tkey5Active==1) Debug.Log("tkey5Active=1");
    }
}

    