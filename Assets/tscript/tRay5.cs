using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tRay5 : MonoBehaviour
{
public  tkeyTrigger9 TkeyTrigger9;
     public float MaxScale = 1.06f;
    public float scale = 0f;
    public float deltaScale = 1f;
    public float tRay5starttime=1.01f;
    public GameObject twall9lMode;
    public int twall9music=1;
    // Start is called before the first frame update
    void Start()
    {
        twall9lMode = GameObject.Find("twall9l");
    }

    // Update is called once per frame
    void Update()
    {
        if(TkeyTrigger9.tkey9Active==1&&scale < MaxScale
        &&Time.time>TkeyTrigger9.tkey9time+tRay5starttime){
            GetComponent<SpriteRenderer>().enabled=true;
             scale += deltaScale * Time.deltaTime;
            transform.localScale = new Vector3(0.14f, scale, 2.8571f);
            twall9lMode.GetComponent<SpriteRenderer>().enabled = true;
           if(twall9music==1) {twall9lMode.GetComponent<AudioSource>().Play();twall9music=0;}
        }
    }
}