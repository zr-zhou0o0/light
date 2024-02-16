using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key2 : MonoBehaviour
{

    public GameObject key2lMode;
    public int key2Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        key2lMode = GameObject.Find("key2l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((key2Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("key2l is light!");
            key2lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
