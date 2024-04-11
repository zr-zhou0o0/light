using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall13 : MonoBehaviour
{

    public GameObject wall13lMode;
    public int wall13Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        wall13lMode = GameObject.Find("wall13l_move");
    }

    // Update is called once per frame
    void Update()
    {
        if ((wall13Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("wall13 is light!");
            wall13lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
