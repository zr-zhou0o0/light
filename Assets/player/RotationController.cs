using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RotationController : MonoBehaviour
{ public GameObject troleMode;
    public int tkey3Active;
    public int tkeyPrevActive3;
    public GameObject tkeyPrev3;
      public int twall1Active;
    public int twallPrevActive1;
    public GameObject twallPrev1;
   

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
         tkeyPrev3 = GameObject.Find("tkeyTrigger3");
        tkeyPrevActive3=tkeyPrev3.GetComponent<tkeyTrigger3>().tkey3Active;
         twallPrev1 = GameObject.Find("twallTrigger1");
        twallPrevActive1=twallPrev1.GetComponent<twallTrigger1>().twall1Active;
        
       // if (tkeyPrevActive3==1)Debug.Log("tkeyPrevActive3==1");
        // if ( twallPrevActive1==1)Debug.Log(" twallPrevActive1==1");
       if (tkeyPrevActive3==1)
       {transform.eulerAngles=new Vector3(0,0,-90);
         GetComponent<Rigidbody2D>().AddForce(new Vector2(1,0)*-70);
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0,1)*9.81f);
       }
       if(twallPrevActive1==1){
      transform.eulerAngles=new Vector3(0,0,0);
      GetComponent<Rigidbody2D>().AddForce(new Vector2(1,0)*70);
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0,1)*-9.81f);
       }
      
    }
   
}

