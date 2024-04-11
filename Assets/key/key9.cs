using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key9 : MonoBehaviour
{

    public GameObject key9lMode;
    public int key9Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        key9lMode = GameObject.Find("key9l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((key9Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("key9l is light!");
            key9lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
