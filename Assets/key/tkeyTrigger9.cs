using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tkeyTrigger9 : MonoBehaviour
{

 public int tkey9Active=0;
public float tkey9time;

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
        tkey9Active=1;
        tkey9time=Time.time;
    }
}

    