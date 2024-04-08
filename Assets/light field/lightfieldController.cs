using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightfieldController : MonoBehaviour
{
   
    public GameObject troleMode;
    public tkey6 Tkey6;
    public int touchlightfield;
    // Start is called before the first frame update
    void Start()
    {
       
        troleMode = GameObject.Find("role0");

    }

    // Update is called once per frame
    void Update()
    {
        FlyUp(); 
    }
    private void OnTriggerEnter2D(Collider2D collision){
        Debug.Log("touchs trigger");
        if(Tkey6.area2l==1){
            touchlightfield=1;
        }
    }

    public void FlyUp(){
    if(Tkey6.area2l==1&& touchlightfield==1&&troleMode.transform.position.y<9.87&&troleMode.transform.position.x<-9.94f&&troleMode.transform.position.x>-14.16f){
   troleMode.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,1)*11f);
    }
    }
}
