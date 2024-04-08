using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class tkeyTrigger3 : MonoBehaviour
{

   public GameObject tlight3lMode;
  public int tkey3Active = 0;
    public int tkey2Active;
    public int tkey1Active;

     public int tkeyPrevActive2;
 public GameObject tkeyPrev2;
  public int tkeyPrevActive1;
 public GameObject tkeyPrev1;
  public int tkeyPrevActive3;
 public GameObject tkeyPrev3;
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

         tkeyPrev2 = GameObject.Find("tkeyTrigger2");
        tkeyPrevActive2=tkeyPrev2.GetComponent<tkeyTrigger2>().tkey2Active;
        
        GetComponent<AudioSource>().Play();
        Debug.Log("tkeytrigger3 is 1");

            tlight3lMode = GameObject.Find("tlight3l");
            if( tkeyPrevActive1==1&&tkeyPrevActive2==1){
                if(tkey3Active==0)
                tkey3Active = 1;
                else{
                    tkey3Active=0;
                    tkeyPrev1.GetComponent<tkeyTrigger1>().tkey1Active=0;
                    tkeyPrev2.GetComponent<tkeyTrigger2>().tkey2Active=0;
                }
                }
              
         
    }
}

    