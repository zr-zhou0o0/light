using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkey23d : MonoBehaviour
{
    public GameObject pkey23lMode;
    public int pkey23Active = 0;
    public int relativeThingActive = 0;
    public double height;
    public GameObject SetActiveObject1;
    public pkeyTrigger23 anything1;
    // Start is called before the first frame update
    void Start()
    {
        pkey23lMode = GameObject.Find("pkey23l");
        SetActiveObject1 = GameObject.Find("pkey23d");
    }

    // Update is called once per frame
    void Update()
    {
        height = SetActiveObject1.GetComponent<pkey23d>().transform.position.y;
        if ((anything1.pkeyTrigger23Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pkey23l is light!");
            pkey23lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
        if ((anything1.pkeyTrigger23Active == 1) && (relativeThingActive == 1))
        {
            if (height < (-16.40))
            {
                SetActiveObject1.transform.Translate(new Vector3(0, 3, 0) * 0.001f);
            }
            if (height >= (-16.40))
            {
                height = -16.40;
            }
        }

    }
}
