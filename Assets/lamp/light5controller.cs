using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light5controller : MonoBehaviour
{
    public GameObject trigger;
    public int lock5 = 0;
    public int light5Active = 0;
    public int relativeThingActive = 0;

    public GameObject light5lMode;

    // Start is called before the first frame update
    void Start()
    {
        trigger = GameObject.Find("enterTrigger8");
        light5lMode = GameObject.Find("light5l");
    }

    // Update is called once per frame
    void Update()
    {
        if (lock5 == 0)
        {
            lock5 = trigger.GetComponent<room8Enter>().lock8;
        }

        if(lock5 == 1 && relativeThingActive == 0)
        {
            light5Active = 1;
            light5lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }

    }
}
