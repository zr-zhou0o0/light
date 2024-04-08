using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public twall12Trigger Twall12Trigger;
    public Transform playerTarget;
    public int cameramove=1;
    public int cameramove1=1;
        // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    if(Twall12Trigger.tRay1Active==1&&transform.position.y<14.87&&cameramove==1){
        transform.Translate(new Vector3(0, 1, 0)*0.01f);
    }
    if(playerTarget.position.y<9){
    cameramove=0;
    if(transform.position.y>4&&cameramove1==1){
    transform.Translate(new Vector3(0, -1, 0)*0.01f);
    cameramove1=0;}
    }
   
    }
}
