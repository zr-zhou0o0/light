using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gearTrigger4 : MonoBehaviour
{
    public int gearTrigger4Active = 0;
    public int relativeThingActive = 0;

    public int gearActive = 0;

    public float wallStartTime = 0;
    public float wallMoveDeltaTime = 6;//���������Ϸ�ű������ҲҪ�ģ�����û�ã�����Ѫ��Ľ�ѵ��

    public GameObject gear;
    public GameObject wall;


    // Start is called before the first frame update
    void Start()
    {
        gear = GameObject.Find("gear4d");
        wall = GameObject.Find("wall25d");


    }

    // Update is called once per frame
    void Update()
    {

        gearActive = gear.GetComponent<gear4>().gear4Active;


        if (gearTrigger4Active == 1)//&& (relativeThingActive == 0))
        {
            // Debug.Log("active gear and wall!");
            gear.transform.Rotate(new Vector3(0, 0, 1), 0.5f);//Ҫһֱת�Ļ��Ͳ�������relativethingactive������ֻתһ˲�䣬����������

        }

        if ((gearTrigger4Active == 1) && (relativeThingActive == 0))
        {
            wallStartTime = Time.time;
            GetComponent<AudioSource>().Play();
            relativeThingActive = 1;
            Debug.Log(Time.time);
            Debug.Log(wallMoveDeltaTime);
            Debug.Log(Time.time + wallMoveDeltaTime);
        }

        if ((Time.time > wallStartTime) && (Time.time < wallStartTime + wallMoveDeltaTime) && (relativeThingActive == 1))
        {
            wall.transform.Translate(new Vector3(0, 1, 0) * 0.5f * Time.deltaTime);
        }


    }



    public void OnMouseDown()//Ҫ���������collider2d�͡��Ǵ�������ѡ��
    {
        Debug.Log("mouse down!");
        if (gearActive == 1)//���������ŵ�ʱ��
        {
            gearTrigger4Active = 1;
            Debug.Log("geartrigger1active is 1");
        }
    }

}