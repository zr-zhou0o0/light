using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkey19d : MonoBehaviour
{
    public GameObject pkey19lMode;
    public int relativeThingActive;
    public pkeyTrigger19 anything1;
    // Start is called before the first frame update
    void Start()
    {
        pkey19lMode= GameObject.Find("pkey19l");
        relativeThingActive = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if ((anything1.pkeyTrigger19Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pkey19l is light!");
            pkey19lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
