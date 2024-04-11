using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkey20d : MonoBehaviour
{
    public GameObject pkey20lMode;
    public GameObject SetActiveObject1;
    public pkeyTrigger20 anything1;
    public pkeyTrigger19 anything2;
    public double height;
    public int relativeThingActive;
    public int pkey20Active;
    public int direction1;
    public int direction2;
    public int direction;
    public plight14controller anything3;
    // Start is called before the first frame update
    void Start()
    {
        pkey20lMode = GameObject.Find("pkey20l");
        //SetActiveObject2= GameObject.Find("pkeyTrigger20");
        height = 0;
        SetActiveObject1 = GameObject.Find("pkey20d");
        relativeThingActive = 0;
        direction1 = 0;
        direction2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //pkey20Active = SetActiveObject2.GetComponent< pkeyTrigger20 >
        height = SetActiveObject1.GetComponent<pkey20d>().transform.position.y;
        if ( (anything2.pkeyTrigger19Active == 1)&&(anything1.pkeyTrigger20Active == 0))
        {
            if (height >= (-25.24))
            {
                SetActiveObject1.transform.Translate(new Vector3(0, -3, 0) * 0.001f);

            }
            if (height <(-25.24))
            {
                height = -25.24;
            }
            /*if (direction == direction1)
            {
                SetActiveObject1.transform.Translate(new Vector3(0, -3, 0) * 0.001f);
            }*/
        }
       
        if ((anything3.setActiveObject5==1)&&(anything1.pkeyTrigger20Active==1)&&(relativeThingActive == 0))
        {
            Debug.Log("pkey20l is light!");
            pkey20lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
        if ((anything3.setActiveObject5 == 1) && (anything1.pkeyTrigger20Active == 1))
        {
            //height = Vector3.MoveTowards(height,new Vector3(14.80,-22.43,0));
            //SetActiveObject1.GetComponent<pkey20d>().transform.position = Vector3.MoveTowards(SetActiveObject1.GetComponent<pkey20d>().transform.position, new Vector3(14.8, -22, 0));
            if (height < (-22.43))
            {
                SetActiveObject1.transform.Translate(new Vector3(0, 3, 0) * 0.001f);
            }
            if (height >= (-22.43))
            {
                height = -25.24;
            }
        }
    }
}
