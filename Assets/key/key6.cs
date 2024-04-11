using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key6 : MonoBehaviour
{

    public GameObject key6lMode;
    public int key6Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        key6lMode = GameObject.Find("key6l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((key6Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("key6l is light!");
            key6lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
