using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pwall17 : MonoBehaviour
{

    public GameObject pwall17lMode;
    public int pwall17Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        pwall17lMode = GameObject.Find("pwall17l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((pwall17Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("wall17l is light!");
            pwall17lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
