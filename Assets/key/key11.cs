using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key11 : MonoBehaviour
{

    public GameObject key11lMode;
    public int key11Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        key11lMode = GameObject.Find("key11l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((key11Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("key11l is light!");
            key11lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
