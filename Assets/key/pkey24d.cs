using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkey24d : MonoBehaviour
{
    public GameObject pkey24lMode;
    public int pkey24Active = 0;
    public int relativeThingActive = 0;
    public double height;
    public GameObject SetActiveObject1;
    public plight15controller anything1;
    public pkeyTrigger24 anything;
    // Start is called before the first frame update
    void Start()
    {
        pkey24lMode = GameObject.Find("pkey24l");
        SetActiveObject1 = GameObject.Find("pkey24d");
    }

    // Update is called once per frame
    void Update()
    {
        height = SetActiveObject1.GetComponent<pkey24d>().transform.position.y;
        if ((anything1.setActiveObject5 == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pkey24l is light!");
            pkey24lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
        if (anything.pkeyTrigger24Active == 1)
        {
            if (height < (-12.24))
            {
                SetActiveObject1.transform.Translate(new Vector3(0, 3, 0) * 0.001f);
            }
            if (height >= (-12.24))
            {
                height = -12.24;
            }
        }

    }
}
