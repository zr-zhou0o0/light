using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gear4 : MonoBehaviour
{

    public GameObject gear4lMode;
    public int gear4Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        gear4lMode = GameObject.Find("gear4l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((gear4Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("gear4l is light!");
            gear4lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
