using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pwall8 : MonoBehaviour
{

    public GameObject pwall8lMode;
    public int pwall8Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        pwall8lMode = GameObject.Find("pwall8l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((pwall8Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pwall8l is light!");
            pwall8lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
