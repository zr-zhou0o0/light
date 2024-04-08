using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twall14 : MonoBehaviour
{
     public tkeyTrigger10 TkeyTrigger10;
      public GameObject mytwall14;
      public float twall14movetime=2.1f;
    // Start is called before the first frame update
    void Start()
    {
         mytwall14 = GameObject.Find("twall14d");
    }

    // Update is called once per frame
    void Update()
    {
        if(TkeyTrigger10.tkey10Active1==1&&mytwall14.transform.position.x>-10.205f
        &&Time.time>TkeyTrigger10.tkey10time+twall14movetime){
mytwall14.transform.Translate(new Vector3(0, -1, 0)*0.001f);
        }
    }
}
