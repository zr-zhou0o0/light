using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gear1 : MonoBehaviour
{

    public GameObject gear1lMode;
    public int gear1Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        gear1lMode = GameObject.Find("gear1l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((gear1Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("gear1l is light!");
            gear1lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
