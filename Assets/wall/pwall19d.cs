using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pwall19d : MonoBehaviour
{
    public GameObject pwall19lMode;
    public int pwall19Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        pwall19lMode = GameObject.Find("pwall19l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((pwall19Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("wall19l is light!");
            pwall19lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
