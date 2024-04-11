using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key5 : MonoBehaviour
{

    public GameObject key5lMode;
    public int key5Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        key5lMode = GameObject.Find("key5l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((key5Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("key5l is light!");
            key5lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
