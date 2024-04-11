using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock1 : MonoBehaviour
{

    public GameObject clock1lMode;
    public GameObject clock1Pointer;
    public int clock1Active = 0;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        clock1lMode = GameObject.Find("clock1l");
        clock1Pointer = GameObject.Find("clock1Pointer");
    }

    // Update is called once per frame
    void Update()
    {
        if ((clock1Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("clock1 is light!");
            clock1lMode.GetComponent<SpriteRenderer>().enabled = true;
            clock1Pointer.GetComponent<SpriteRenderer>().enabled = true;

            relativeThingActive = 1;
        }

        if(relativeThingActive == 1)
        {
            clock1Pointer.transform.Rotate(new Vector3(0, 0, -1), 50f * Time.deltaTime);
        }

    }



}
