using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkey13d : MonoBehaviour
{

    public GameObject pkey13lMode;
    public int pkey13Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        pkey13lMode = GameObject.Find("pkey13l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((pkey13Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pkey13l is light!");
            pkey13lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
