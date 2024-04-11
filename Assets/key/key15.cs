using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key15 : MonoBehaviour
{

    public GameObject key15lMode;
    public int key15Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        key15lMode = GameObject.Find("key15l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((key15Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("key15l is light!");
            key15lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
