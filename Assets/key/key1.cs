using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key1 : MonoBehaviour
{

    public GameObject key1lMode;
    public int key1Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        key1lMode = GameObject.Find("key1l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((key1Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("key1l is light!");
            key1lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
