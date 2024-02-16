using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall7 : MonoBehaviour
{

    public GameObject wall7lMode;
    public int wall7Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        wall7lMode = GameObject.Find("wall7l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((wall7Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("wall7l is light!");
            wall7lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
