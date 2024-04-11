using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgear11 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pgear11lMode;
    public int pgear11Active = 0;
    public int relativeThingActive = 0;
    void Start()
    {
        pgear11lMode = GameObject.Find("pgear11l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((pgear11Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pgear11l is light!");
            pgear11lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
