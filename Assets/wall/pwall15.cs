using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pwall15 : MonoBehaviour
{

    public GameObject pwall15lMode;
    public int pwall15Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        pwall15lMode = GameObject.Find("pwall15l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((pwall15Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("wall15l is light!");
            pwall15lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}