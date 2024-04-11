using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkey27d : MonoBehaviour
{
    public GameObject SetActiveObject1;
    private float height;
    public int direction;
    public int direction1;
    public int direction2;
    public pkeyTrigger27 anything;
    public int relativeThingActive;
    public GameObject pkey27lMode;
    // Start is called before the first frame update
    void Start()
    {
        SetActiveObject1 = GameObject.Find("pkey27d");
        direction = 0;
        direction1 = 1;
        direction2 = 2;
        pkey27lMode = GameObject.Find("pkey27l");
        relativeThingActive = 0;
    }

    // Update is called once per frame
    void Update()
    {
        height = SetActiveObject1.GetComponent<pkey27d>().transform.position.y;
        if (height > (-23))
        {
            SetActiveObject1.transform.Translate(new Vector3(0, -3, 0) * 0.4f * Time.deltaTime);
            direction = 1;
            direction1 = 1;
        }
        if (height < (-32))
        {
            SetActiveObject1.transform.Translate(new Vector3(0, 3, 0) * 0.4f * Time.deltaTime);
            direction = 2;
            direction2 = 2;
        }
        if (direction == direction1)
        {
            SetActiveObject1.transform.Translate(new Vector3(0, -3, 0) * 0.4f * Time.deltaTime);
        }
        if (direction == direction2)
        {
            SetActiveObject1.transform.Translate(new Vector3(0, 3, 0) * 0.4f * Time.deltaTime);
        }
        if ((anything.pkeyTrigger27Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pkey27l is light!");
            pkey27lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
