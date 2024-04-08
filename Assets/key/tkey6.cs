using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tkey6 : MonoBehaviour{
    public GameObject tkey6lMode;
    public int tkey6Active = 0;
    public GameObject tkey4lMode;
    public int tkey4Active;
    public GameObject tkey5lMode;
    public int tkey5Active;
    public GameObject tkey7lMode;
    public int tkey7Active;
      public int tkeyPrevActive6;
 public GameObject tkeyPrev6;
    public int tkeyPrevActive4;
 public GameObject tkeyPrev4;
    public int tkeyPrevActive5;
 public GameObject tkeyPrev5;
    public int tkeyPrevActive7;
 public GameObject tkeyPrev7;

   public GameObject twall4lMode;  
   public GameObject twall5lMode;
     public GameObject tlightfield1lMode;
     public int area2l=0;
void Start()
    {
        tkey6lMode = GameObject.Find("tkey6l");
         tkey5lMode = GameObject.Find("tkey5l");
         tkey7lMode = GameObject.Find("tkey7l");
         tkey4lMode = GameObject.Find("tkey4l");
         twall4lMode= GameObject.Find("twall4l");
         twall5lMode= GameObject.Find("twall5l");
         tlightfield1lMode= GameObject.Find("tlightfield1l");
    }
    

    // Update is called once per frame
    void Update()
    {  
        tkeyPrev6 = GameObject.Find("tkeyTrigger6");
        tkeyPrevActive6=tkeyPrev6.GetComponent<tkeyTrigger6>().tkey6Active;
         tkeyPrev4 = GameObject.Find("tkeyTrigger4");
        tkeyPrevActive4=tkeyPrev4.GetComponent<tkeyTrigger4>().tkey4Active;
         tkeyPrev5 = GameObject.Find("tkeyTrigger5");
        tkeyPrevActive5=tkeyPrev5.GetComponent<tkeyTrigger5>().tkey5Active;
         tkeyPrev7 = GameObject.Find("tkeyTrigger7");
        tkeyPrevActive7=tkeyPrev7.GetComponent<tkeyTrigger7>().tkey7Active;
        if ((tkeyPrevActive6 == 1)&&tkeyPrevActive4==1&&tkeyPrevActive5==1&&tkeyPrevActive7==1)
         {
            area2l =1;//control lightfield
            tkey6lMode.GetComponent<SpriteRenderer>().enabled = true;
           
            tkey4lMode.GetComponent<SpriteRenderer>().enabled = true;

            tkey5lMode.GetComponent<SpriteRenderer>().enabled = true;
         
             tkey7lMode.GetComponent<SpriteRenderer>().enabled = true;
     
            twall4lMode.GetComponent<SpriteRenderer>().enabled = true;
           
            twall5lMode.GetComponent<SpriteRenderer>().enabled = true;
         
            tlightfield1lMode.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}