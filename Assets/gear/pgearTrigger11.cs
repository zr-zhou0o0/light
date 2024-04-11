using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgearTrigger11: MonoBehaviour
{
    public int pgearTrigger11Active = 0;
    public int relativeThingActive = 0;

    public int pgearActive = 0;

    public float wallStartTime = 0;
    public float wallMoveDeltaTime = 8;//���������Ϸ�ű������ҲҪ�ģ�����û�ã�����Ѫ��Ľ�ѵ��

    public GameObject gear;
    public GameObject wall1;

    // Start is called before the first frame update
    void Start()
    {
        gear = GameObject.Find("pgear11d");
        wall1 = GameObject.Find("pwall2d");

    }

    // Update is called once per frame
    void Update()
    {

        pgearActive = gear.GetComponent<pgear11>().pgear11Active;


        if (pgearTrigger11Active == 1)//&& (relativeThingActive == 0))
        {
            // Debug.Log("active gear and wall1 and wall2!");
            gear.transform.Rotate(new Vector3(0, 0, 1), 0.5f);//Ҫһֱת�Ļ��Ͳ�������relativethingactive������ֻתһ˲�䣬����������

        }

        if ((pgearTrigger11Active == 1) && (relativeThingActive == 0))
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
            wall1.transform.Translate(new Vector3(0, -3, 0) * 0.3f * Time.deltaTime);
        }


    }



    public void OnMouseDown()//Ҫ���������collider2d�͡��Ǵ�������ѡ��
    {
        Debug.Log("mouse down!");
        if (pgearActive == 1)//���������ŵ�ʱ��
        {
            pgearTrigger11Active = 1;
            Debug.Log("pgeartrigger11active is 1");
        }
    }

}
