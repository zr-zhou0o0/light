using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pwall2 : MonoBehaviour
{

    public GameObject pwall2lMode;
    public int pwall2Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        pwall2lMode = GameObject.Find("pwall2l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((pwall2Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pkey13l is light!");
            pwall2lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
