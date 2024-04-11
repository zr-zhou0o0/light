using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key8 : MonoBehaviour
{

    public GameObject key8lMode;
    public int key8Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        key8lMode = GameObject.Find("key8l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((key8Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("key8l is light!");
            key8lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
