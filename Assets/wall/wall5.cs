using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall5 : MonoBehaviour
{

    public GameObject wall5lMode;
    public int wall5Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        wall5lMode = GameObject.Find("wall5l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((wall5Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("wall5l is light!");
            wall5lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
