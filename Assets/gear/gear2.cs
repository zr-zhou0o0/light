using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gear2 : MonoBehaviour
{

    public GameObject gear2lMode;
    public int gear2Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        gear2lMode = GameObject.Find("gear2l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((gear2Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("gear2 is light!");
            gear2lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
