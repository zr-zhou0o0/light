using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tkey3 : MonoBehaviour{
    public GameObject tkey3lMode;
    public int tkey3Active = 0;

    public int relativeThingActivet3 = 0;
    public GameObject tkey2lMode;
    public int tkey2Active;
    public GameObject tkey1lMode;
    public int tkey1Active;
      public int tkeyPrevActive3;
 public GameObject tkeyPrev3;

   public GameObject twall1lMode;  
   public GameObject twall3lMode;
     public GameObject twall6lMode;
       public GameObject twall7lMode;
void Start()
    {
        tkey3lMode = GameObject.Find("tkey3l");
         tkey2lMode = GameObject.Find("tkey2l");
         tkey1lMode = GameObject.Find("tkey1l");
         twall1lMode= GameObject.Find("twall1l");
         twall3lMode= GameObject.Find("twall3l");
         twall6lMode= GameObject.Find("twall6l");
         twall7lMode= GameObject.Find("twall7l");
    }
    

    // Update is called once per frame
    void Update()
    {  
        tkeyPrev3 = GameObject.Find("tkeyTrigger3");
        tkeyPrevActive3=tkeyPrev3.GetComponent<tkeyTrigger3>().tkey3Active;
        if ((tkeyPrevActive3 == 1)/* && (relativeThingActivet3 == 0)*/)
         {
            tkey3lMode.GetComponent<SpriteRenderer>().enabled = true;
            relativeThingActivet3 = 1;
           
            tkey2lMode.GetComponent<SpriteRenderer>().enabled = true;

            tkey1lMode.GetComponent<SpriteRenderer>().enabled = true;
         
            twall1lMode.GetComponent<SpriteRenderer>().enabled = true;
     
            twall3lMode.GetComponent<SpriteRenderer>().enabled = true;
           
            twall6lMode.GetComponent<SpriteRenderer>().enabled = true;
         
            twall7lMode.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}