using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkey15 : MonoBehaviour
{

    public GameObject pkey15lMode;
    public int pkey15Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        pkey15lMode = GameObject.Find("pkey15l");
    }

    // Update is called once per frame
    void Update()
    {
        if((pkey15Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pkey15l is light!");
            pkey15lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
