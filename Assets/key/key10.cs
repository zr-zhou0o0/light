using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key10 : MonoBehaviour
{

    public GameObject key10lMode;
    public int key10Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        key10lMode = GameObject.Find("key10l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((key10Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("key10l is light!");
            key10lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
