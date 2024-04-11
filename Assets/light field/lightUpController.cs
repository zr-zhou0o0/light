using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightUpController : MonoBehaviour
{
   public lightfieldController a;
   public float MaxScale = 1.56f;
    public float scale = 0f;
    public float deltaScale = 1f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       if (a.touchlightfield == 1 && scale < MaxScale)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            scale += deltaScale * Time.deltaTime;
            transform.localScale = new Vector3(1.649f, scale, 2.8571f);
        }
       
        
    }
      
}
