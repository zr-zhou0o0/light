using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tkeyTrigger8 : MonoBehaviour
{
 public int tkey8Active=0;
 public int tkey8Active1=0;
 public float tkey8time;
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
        Debug.Log("tkeytrigger8 is 1");
        tkey8Active=1;
        tkey8time=Time.time;
    }
}

    