using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkey14d: MonoBehaviour
{

    public GameObject pkey14lMode;
    public int pkey14Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        pkey14lMode = GameObject.Find("pkey14l");

    }

    // Update is called once per frame
    void Update()
    {
        if ((pkey14Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pkey14l is light!");
            pkey14lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
