using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gear11 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gear11lMode;
    public int gear11Active = 0;
    public int relativeThingActive = 0;
    void Start()
    {
        gear11lMode = GameObject.Find("gear11l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((gear11Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("gear11l is light!");
            gear11lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
