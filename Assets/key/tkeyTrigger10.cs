using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tkeyTrigger10 : MonoBehaviour
{

 public int tkey10Active=0;
  public int tkey10Active1=0;
  public float tkey10time;
  public tkey10l Tkey10l;
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
        if(Tkey10l.tkey10mode==1){
        Debug.Log("tkey10Active is 1");
             tkey10Active = 1; 
             if(tkey10Active==1) {tkey10Active1=1;
             Debug.Log("tkey10Active1 is 1");}
             tkey10time=Time.time;}
    }
}

    