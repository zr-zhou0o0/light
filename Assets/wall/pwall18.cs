using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pwall18 : MonoBehaviour
{

    public GameObject pwall18lMode;
    public int pwall18Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        pwall18lMode = GameObject.Find("pwall18l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((pwall18Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("wall17l is light!");
            pwall18lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
