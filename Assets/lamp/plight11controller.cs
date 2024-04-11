using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plight11controller : MonoBehaviour
{
    public GameObject trigger;
    public int pLock = 0;
    public int plight11Active = 0;
    public int relativeThingActive = 0;
    private float deltaTime = 0.5f;//从解锁（激活）到变亮的时间
    private float startTime = 0f;

    //以下这些游戏物体是这盏灯控制的
    public GameObject light11lMode;
    public GameObject setActiveObject1;
    public GameObject setActiveObject2;
    public GameObject setActiveObject3;
    public GameObject setActiveObject4;//剩下几个是竖着的墙和齿轮
    public GameObject setActiveObject5;
    public GameObject setActiveObject6;
    public GameObject setActiveObject7;
    public pwall15 anything;



    // Start is called before the first frame update
    void Start()
    {
        //初始化：找到关联的物体
        trigger = GameObject.Find("pkeyTrigger14");
        light11lMode = GameObject.Find("plight11l");
        setActiveObject1 = GameObject.Find("pkey13d");
        setActiveObject2 = GameObject.Find("pkey14d");
        setActiveObject3 = GameObject.Find("pwall2d");
        setActiveObject4 = GameObject.Find("pwall8d");
        setActiveObject5 = GameObject.Find("pwall15d");
        setActiveObject6 = GameObject.Find("pwall16d");
        setActiveObject7 = GameObject.Find("pgear11d");
    }

    // Update is called once per frame
    void Update()
    {
        //查看是不是已经解锁
        if (pLock == 0)
        {
            pLock = trigger.GetComponent<pkeyTrigger14>().plock14;
        }

        //灯的状态改成激活
        if ((pLock == 1) && (startTime == 0f))
        {
            plight11Active = 1;
            Debug.Log("light11active is 1");
            startTime = Time.time;

            Debug.Log(startTime);
            Debug.Log(deltaTime);
        }

        //将物体点亮
        if ((plight11Active == 1) && (Time.time > startTime + deltaTime) && (relativeThingActive == 0))//解锁之后经过短暂的时间
        {
            Debug.Log("its time to active");
            anything.pwall15Active = 1;
            light11lMode.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject1.GetComponent<pkey13d>().pkey13Active = 1;
            setActiveObject2.GetComponent<pkey14d>().pkey14Active = 1;
            setActiveObject3.GetComponent<pwall2>().pwall2Active = 1;
            setActiveObject4.GetComponent<pwall8>().pwall8Active = 1;
            setActiveObject5.GetComponent<pwall15>().pwall15Active = 1;
            setActiveObject6.GetComponent<pwall16>().pwall16Active = 1;
            setActiveObject7.GetComponent<pgear11>().pgear11Active = 1;


            GetComponent<AudioSource>().enabled = true;

            relativeThingActive = 1;//防止在点亮之后还会一直check，浪费性能
        }

    }
}
