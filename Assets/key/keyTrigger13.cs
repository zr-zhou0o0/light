using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger13 : MonoBehaviour
{
    public GameObject clockTrigger;
   // public Component clockTrigger1;
    // Start is called before the first frame update
    void Start()
    {
        clockTrigger = GameObject.Find("clockTrigger1");
        //clockTrigger1 = clockTrigger.GetComponent<clockTrigger1>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        clockTrigger.GetComponent<clockTrigger1>().keyNumber[3] = clockTrigger.GetComponent<clockTrigger1>().keyNumber[2];
        clockTrigger.GetComponent<clockTrigger1>().keyNumber[2] = clockTrigger.GetComponent<clockTrigger1>().keyNumber[1];
        clockTrigger.GetComponent<clockTrigger1>().keyNumber[1] = clockTrigger.GetComponent<clockTrigger1>().keyNumber[0];
        clockTrigger.GetComponent<clockTrigger1>().keyNumber[0] = 13;
        GetComponent<AudioSource>().Play();
    }

}
