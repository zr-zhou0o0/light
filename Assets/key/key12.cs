using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key12 : MonoBehaviour
{

    public GameObject key12lMode;
    public int key12Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        key12lMode = GameObject.Find("key12l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((key12Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("key12l is light!");
            key12lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
