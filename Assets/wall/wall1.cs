using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall1 : MonoBehaviour
{

    public GameObject wall1lMode;//这个是wall，一，light Mode的意思
    public int wall1Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        wall1lMode = GameObject.Find("wall1l");
    }

    // Update is called once per frame
    void Update()
    {
        if ((wall1Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("wall1l is light!");
            wall1lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
