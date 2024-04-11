using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twall14l : MonoBehaviour
{
    public tkeyTrigger10 TkeyTrigger10;
    public float twall14lighttime=2.09f;
    public GameObject twall15lMode;
     public GameObject twall13lMode;
      public GameObject twall11lMode;
        public GameObject twall8lMode;
        public int twall14music=1;
    // Start is called before the first frame update
    void Start()
    {
         twall15lMode = GameObject.Find("twall15l");
         twall13lMode = GameObject.Find("twall13l");
         twall11lMode = GameObject.Find("twall11l");
          twall8lMode = GameObject.Find("twall8l");
    }

    // Update is called once per frame
    void Update()
    {
       if(TkeyTrigger10.tkey10Active1==1
       &&Time.time>TkeyTrigger10.tkey10time+twall14lighttime){
         GetComponent<SpriteRenderer>().enabled=true;
         twall15lMode.GetComponent<SpriteRenderer>().enabled = true;
         twall13lMode.GetComponent<SpriteRenderer>().enabled = true;
        twall11lMode.GetComponent<SpriteRenderer>().enabled = true;
        twall8lMode.GetComponent<SpriteRenderer>().enabled = true;
        if(twall14music==1){
          GetComponent<AudioSource>().Play();
          twall14music=0;
        }
       } 
    }
}
