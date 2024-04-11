using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key7 : MonoBehaviour
{

    public GameObject key7lMode;
    public int key7Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        key7lMode = GameObject.Find("key7l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((key7Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("key7l is light!");
            key7lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
