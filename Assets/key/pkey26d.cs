using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkey26d : MonoBehaviour
{
    public GameObject pkey26lMode;
    public int pkey26Active = 0;
    public int relativeThingActive = 0;
    public plight15controller anything1;
    public double height;
    public GameObject SetActiveObject1;

    // Start is called before the first frame update
    void Start()
    {
        pkey26lMode = GameObject.Find("pkey26l");
        SetActiveObject1 = GameObject.Find("pkey26d");

    }

    // Update is called once per frame
    void Update()
    {
        height = SetActiveObject1.GetComponent<pkey26d>().transform.position.y;
        if ((anything1.setActiveObject5 == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pkey26l is light!");
            pkey26lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
