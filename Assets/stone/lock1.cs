using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lock1 : MonoBehaviour
{
    public int[] arr = new int[3] { 3, 3, 3 };
    public float spotTime = -10f;
    // Start is called before the first frame update
    void Start()
    {
        arr = new int[3] { 0, 0, 0 };
    }

    // Update is called once per frame
    void Update()
    {
        if(arr[0] == 5 && arr[1] == 3 && arr[2] == 4)
        {
            //Debug.Log("unlock!!");
            ////
            GameObject.Find("d6").GetComponent<d6>().d6atv = 1;
            if(spotTime == -10f) spotTime = Time.time;

        }

        if(Time.time > spotTime+1f && Time.time < spotTime + 2f)
        {
            GameObject.Find("spotTrigger3").GetComponent<spotTrigger3>().spotActive = 1;
        }
    }
}
