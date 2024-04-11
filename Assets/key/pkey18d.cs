using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkey18d : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pkey18lMode;
    public GameObject SetActiveObject1;
    public pkeyTrigger18 anything1;
    public pkeyTrigger19 anything2;
    public double height;
    public int relativeThingActive;
    public int direction1;
    public int direction2;
    public int direction;
    void Start()
    {
        pkey18lMode = GameObject.Find("pkey18l");
        height = 0;
        SetActiveObject1 = GameObject.Find("pkey18d");
        relativeThingActive = 0;
        direction1 = 0;
        direction2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        height = SetActiveObject1.GetComponent<pkey18d>().transform.position.y;
        if ((anything1.pkeyTrigger18Active == 1)&&(anything2.pkeyTrigger19Active==0))
        {
            if (height >= (-23.75))
            {
                SetActiveObject1.transform.Translate(new Vector3(0, -3, 0) * 0.3f * Time.deltaTime);
                direction = 1;
                direction1 = 1;
            }
            if (height <= (-27.24))
            {
                SetActiveObject1.transform.Translate(new Vector3(0, 3, 0) * 0.3f * Time.deltaTime);
                direction = 2;
                direction2 = 2;
            }
            if (direction == direction1)
            {
                SetActiveObject1.transform.Translate(new Vector3(0, -3, 0) * 0.1f * Time.deltaTime);
            }
            if (direction == direction2)
            {
                SetActiveObject1.transform.Translate(new Vector3(0, 3, 0) * 0.3f * Time.deltaTime);
            }
        }
        if ((anything1.pkeyTrigger18Active == 1) && (anything2.pkeyTrigger19Active == 1))
        {
            height = -25.24;
        }
        if ((anything1.pkeyTrigger18Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pkey18l is light!");
            pkey18lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
