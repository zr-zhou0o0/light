using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tkey9d : MonoBehaviour
{
    public tkeyTrigger8 TkeyTrigger8; 
    public tkeyTrigger9 TkeyTrigger9;
    public int canRotate=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if(TkeyTrigger9.tkey9Active==1&&canRotate==1){
            transform.Rotate(Vector3.forward*(-1f),Space.Self);
 }
 if(transform.localRotation.z<-11f)canRotate=0;*/
    }
    
}
