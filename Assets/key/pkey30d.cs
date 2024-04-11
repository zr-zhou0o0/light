using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkey30d : MonoBehaviour
{
    public GameObject SetActiveObject1;
    private float height;
    public int direction;
    public int direction1;
    public int direction2;
    public pkeyTrigger30 anything;
    public int relativeThingActive;
    public GameObject pkey30lMode;
    // Start is called before the first frame update
    void Start()
    {
        SetActiveObject1 = GameObject.Find("pkey30d");
        pkey30lMode = GameObject.Find("pkey30l");
        direction = 0;
        direction1 = 1;
        direction2 = 2;
        relativeThingActive = 0;
    }

    // Update is called once per frame
    void Update()
    {
        height = SetActiveObject1.GetComponent<pkey30d>().transform.position.y;
        if (height > (-28))
        {
            SetActiveObject1.transform.Translate(new Vector3(0, -3, 0) * 0.002f);
            direction = 1;
            direction1 = 1;
        }
        if (height < (-32))
        {
            SetActiveObject1.transform.Translate(new Vector3(0, 3, 0) * 0.001f);
            direction = 2;
            direction2 = 2;
        }
        if (direction == direction1)
        {
            SetActiveObject1.transform.Translate(new Vector3(0, -3, 0) * 0.002f);
        }
        if (direction == direction2)
        {
            SetActiveObject1.transform.Translate(new Vector3(0, 3, 0) * 0.001f);
        }
        if ((anything.pkeyTrigger30Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pkey30l is light!");
            pkey30lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
}
