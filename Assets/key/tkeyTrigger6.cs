using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tkeyTrigger6 : MonoBehaviour
{

 public int tkey6Active;
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
        Debug.Log("tkeytrigger6 is 1");
            
             tkey6Active = 1; 
             if(tkey6Active==1) Debug.Log("tkey6Active=1");
    }
}

    