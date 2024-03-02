using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key14 : MonoBehaviour
{

    public GameObject key14lMode;
    public int key14Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        key14lMode = GameObject.Find("key14");
    }

    // Update is called once per frame
    void Update()
    {
        if ((key14Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("key2l is light!");
            key14lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
