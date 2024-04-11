using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pwall16 : MonoBehaviour
{

    public GameObject pwall16lMode;//这个是wall，一，light Mode的意思
    public int pwall16Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        pwall16lMode = GameObject.Find("pwall16l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((pwall16Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pwall16l is light!");
            pwall16lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
