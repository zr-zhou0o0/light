using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall11 : MonoBehaviour
{
    public int wall11Active = 0;
    public int relativeThingActive = 0;

    public float wallStartTime;
    public float wallMoveDeltaTime = 6;//这里改了也要在控制面板里改

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(wall11Active == 1 && relativeThingActive == 0)
        {
            wallStartTime = Time.time;
            GetComponent<AudioSource>().Play();
            Debug.Log(Time.time);
            Debug.Log(wallMoveDeltaTime);
            Debug.Log(Time.time + wallMoveDeltaTime);
            relativeThingActive = 1;
        }

        if((relativeThingActive == 1) &&(Time.time > wallStartTime)&&(Time.time<wallStartTime + wallMoveDeltaTime))
        {
            transform.Translate(new Vector3(0, -1, 0) * 0.5f * Time.deltaTime);
            //transform.position += new Vector3(1.5f * Time.deltaTime, 0, 0);
        }
    }
}
