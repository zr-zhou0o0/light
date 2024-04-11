using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class pkey31d : MonoBehaviour
{
    public GameObject SetActiveObject1;
    public GameObject SetActiveObject2;
    private float height;
    public int direction;
    public int direction1;
    public int direction2;
    public GameObject pkey31lMode;
    //public int pkey31Active;
    public int relativeThingActive;
    public int Trigger31Active;
    public pkeyTrigger31 anything;
    // Start is called before the first frame update
    void Start()
    {
        SetActiveObject1= GameObject.Find("pkey31d");
        pkey31lMode = GameObject.Find("pkey31l");
        direction = 0;
        direction1 = 1;
        direction2 = 2;
        SetActiveObject2 = GameObject.Find("pkeyTrigger31");
        //Trigger31Active = SetActiveObject2.GetComponent<pkeyTrigger31>().pkeyTrigger31Active;
        
        relativeThingActive = 0;
    }

    // Update is called once per frame

    /*public void OnCollisionEnter2D(Collision2D collision)
    {
        pkeyTrigger31Active = 1;
        GetComponent<AudioSource>().Play();
        Debug.Log("pkeytrigger31 is 1");
    }*/
   
    void Update()
    {
        height = SetActiveObject1.GetComponent<pkey31d>().transform.position.y;
        if (height > (-25))
        {
            SetActiveObject1.transform.Translate(new Vector3(0, -3, 0) * 0.001f);
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
            SetActiveObject1.transform.Translate(new Vector3(0, -3, 0) * 0.001f);
        }
        if (direction == direction2)
        {
            SetActiveObject1.transform.Translate(new Vector3(0, 3, 0) * 0.001f);
        }
       
        if ((anything.pkeyTrigger31Active == 1) && (relativeThingActive == 0))
        {
            Debug.Log("pkey31l is light!");
            pkey31lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActive = 1;
        }
    }
    
}
