using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkey28d : MonoBehaviour
{
    public GameObject SetActiveObject1;
    private float height;
    public int direction;
    public int direction1;
    public int direction2;
    public pkeyTrigger28 anything;
    public int relativeThingActive;
    public GameObject pkey28lMode;
    // Start is called before the first frame update
    void Start()
    {
        SetActiveObject1 = GameObject.Find("pkey28d");
        direction = 0;
        direction1 = 1;
        direction2 = 2;
        pkey28lMode = GameObject.Find("pkey28l");
        relativeThingActive = 0;

    }

    // Update is called once per frame
    void Update()
    {
        height = SetActiveObject1.GetComponent<pkey28d>().transform.position.y;
        if (height > (-26))
        {
            SetActiveObject1.transform.Translate(new Vector3(0, -3, 0) * 0.001f);
            direction = 1;
            direction1 = 1;
        }
        if (height < (-32))
        {
            SetActiveObject1.transform.Translate(new Vector3(0, 3, 0) * 0.002f);
            direction = 2;
            direction2 = 2;
        }
        if (direction == direction1)
        {
            SetActiveObject1.transform.Translate(new Vector3(0, -3, 0) * 0.001f);
        }
        if (direction == direction2)
        {
            SetActiveObject1.transform.Translate(new Vector3(0, 3, 0) * 0.002f);
        }
        if ((anything.pkeyTrigger28Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pkey28l is light!");
            pkey28lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
