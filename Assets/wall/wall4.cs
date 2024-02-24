using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall4 : MonoBehaviour
{

    public GameObject wall4lMode;
    public int wall4Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        wall4lMode = GameObject.Find("wall4l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((wall4Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("wall4l is light!");
            wall4lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
