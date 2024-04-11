using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkey25d : MonoBehaviour
{
    public GameObject pkey25lMode;
    public int pkey25Active = 0;
    public int relativeThingActive = 0;
    public plight15controller anything1;
    public double height;
    public GameObject SetActiveObject1;
    public pkeyTrigger25 anything;
    // Start is called before the first frame update
    void Start()
    {
        pkey25lMode = GameObject.Find("pkey25l");
        SetActiveObject1 = GameObject.Find("pkey25d");

    }

    // Update is called once per frame
    void Update()
    {
        height = SetActiveObject1.GetComponent<pkey25d>().transform.position.y;
        if ((anything1.setActiveObject5 == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pkey25l is light!");
            pkey25lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
        if (anything.pkeyTrigger25Active == 1)
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
