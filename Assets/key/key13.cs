using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key13 : MonoBehaviour
{

    public GameObject key13lMode;
    public int key13Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        key13lMode = GameObject.Find("key13l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((key13Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("key13l is light!");
            key13lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
