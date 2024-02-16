using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall6 : MonoBehaviour
{

    public GameObject wall6lMode;
    public int wall6Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        wall6lMode = GameObject.Find("wall6l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((wall6Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("wall6l is light!");
            wall6lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
