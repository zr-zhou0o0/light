using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tkeyTrigger2 : MonoBehaviour
{

   public GameObject tlight2lMode;
  public int tkeyTrigger1Active;

 public int tkeyPrevActive1;
 public GameObject tkeyPrev1;

  public int tkey1Active;
   public int tkey2Active=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        tkeyPrev1 = GameObject.Find("tkeyTrigger1");
        tkeyPrevActive1=tkeyPrev1.GetComponent<tkeyTrigger1>().tkey1Active;
        if(tkeyPrevActive1==1)
        Debug.Log("tkeyPrevActive1=1");
       GetComponent<AudioSource>().Play();
        Debug.Log("tkeytrigger2 is 1");
            tlight2lMode = GameObject.Find("tlight2l");
            if( tkeyPrevActive1==1){
                if(tkey2Active==0)
                tkey2Active = 1;
                else{
                    tkey2Active=0;
                    tkeyPrev1.GetComponent<tkeyTrigger1>().tkey1Active=0;
                }
                }
            if(tkey2Active==1)Debug.Log("tkey2active is 1");
    }

}

    