using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tkeyTrigger1 : MonoBehaviour
{
public GameObject tlight1lMode;
 public int tkey1Active;
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
        Debug.Log("tkeytrigger1 is 1");
            tlight1lMode = GameObject.Find("tlight1l");
             tkey1Active = 1; 
             if(tkey1Active==1) Debug.Log("tkeyActive=1");
    }
}

    