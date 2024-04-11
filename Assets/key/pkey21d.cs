using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkey21d : MonoBehaviour
{
    public GameObject pkey21lMode;
    public int pkey21Active = 0;
    public int relativeThingActive = 0;
    public double height;
    public GameObject SetActiveObject1;
    public pkeyTrigger21 anything1;
    // Start is called before the first frame update
    void Start()
    {
        pkey21lMode = GameObject.Find("pkey21l");
        SetActiveObject1= GameObject.Find("pkey21d");
    }

    // Update is called once per frame
    void Update()
    {
        height = SetActiveObject1.GetComponent<pkey21d>().transform.position.y;
        if ((anything1.pkeyTrigger21Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pkey21l is light!");
            pkey21lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
        if ((anything1.pkeyTrigger21Active == 1) && (relativeThingActive == 1))
        {
            if (height < (-19.92))
            {
                SetActiveObject1.transform.Translate(new Vector3(0, 3, 0) * 0.001f);
            }
            if (height >= (-19.92))
            {
                height = -19.92;
            }
        }

    }
}
