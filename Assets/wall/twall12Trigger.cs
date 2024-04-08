using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twall12Trigger : MonoBehaviour
{
    public int tRay1Active=0;
    public float twall12time;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter2D(Collider2D collision){
    tRay1Active=1;
    twall12time=Time.time;
     }
}
