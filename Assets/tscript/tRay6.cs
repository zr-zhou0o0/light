using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tRay6 : MonoBehaviour
{
    public tkeyTrigger10 TkeyTrigger10;
     public float MaxScale = 1.06f;
    public float scale = 0f;
    public float deltaScale = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(TkeyTrigger10.tkey10Active==1&&scale < MaxScale){
 GetComponent<SpriteRenderer>().enabled = true;
          scale += deltaScale * Time.deltaTime;
            transform.localScale = new Vector3(0.14f, scale, 2.8571f);
       }
    }
}
