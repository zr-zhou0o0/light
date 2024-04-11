using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tRay1 : MonoBehaviour
{
    public twall12Trigger Twall12Trigger;
    public float MaxScale = 1.56f;
    public float scale = 0f;
    public float deltaScale = 1f;
      public GameObject twall10lMode;
    // Start is called before the first frame update
    void Start()
    {
         twall10lMode = GameObject.Find("twall10l");
    }

    // Update is called once per frame
    void Update()
    {
      if(Twall12Trigger. tRay1Active==1&&scale < MaxScale){
        GetComponent<SpriteRenderer>().enabled = true;
        scale += deltaScale * Time.deltaTime;
            transform.localScale = new Vector3(0.14f, scale, 2.8571f);
            twall10lMode.GetComponent<SpriteRenderer>().enabled = true;
      } 
    }
}
