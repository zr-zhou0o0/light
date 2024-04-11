using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkey16 : MonoBehaviour
{

    public GameObject pkey16lMode;
    public int pkey16Active = 0;
    public int relativeThingActive = 0;
    public GameObject lightcontroller;

    // Start is called before the first frame update
    void Start()
    {
        pkey16lMode = GameObject.Find("pkey16l");

    }

    // Update is called once per frame
    private void Update()
    {
        if((pkey16Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pkey16l is light!");
            pkey16lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
