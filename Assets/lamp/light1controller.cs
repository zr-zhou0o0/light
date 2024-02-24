using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light1controller : MonoBehaviour
{
    public GameObject trigger;
    public int Lock = 0;
    public int light1Active = 0;
    public int relativeThingActive = 0;
    private float deltaTime = 0.5f;//从解锁（激活）到变亮的时间
    private float startTime = 0f;

    //以下这些游戏物体是这盏灯控制的
    public GameObject light1lMode;
    public GameObject setActiveObject1;
    public GameObject setActiveObject2;
    public GameObject setActiveObject3;
    public GameObject setActiveObject4;//剩下几个是竖着的墙和齿轮
    public GameObject setActiveObject5;
    public GameObject setActiveObject6;
    public GameObject setActiveObject7;
    public GameObject setActiveObject8;//齿轮


    // Start is called before the first frame update
    void Start()
    {
        //初始化：找到关联的物体
        trigger = GameObject.Find("keyTrigger1");
        light1lMode = GameObject.Find("light1l");
        setActiveObject1 = GameObject.Find("key1d");
        setActiveObject2 = GameObject.Find("key2d");
        setActiveObject3 = GameObject.Find("wall1d");
        setActiveObject4 = GameObject.Find("wall4d");
        setActiveObject5 = GameObject.Find("wall5d");
        setActiveObject6 = GameObject.Find("wall6d");
        setActiveObject7 = GameObject.Find("wall7d");
        setActiveObject8 = GameObject.Find("gear1d");
    }

    // Update is called once per frame
    void Update()
    {
        //查看是不是已经解锁
        if (Lock == 0)
        {
            Lock = trigger.GetComponent<keyTrigger1>().lock1;
        }

        //灯的状态改成激活
        if((Lock==1) && (startTime==0f))
        {
            light1Active = 1;
            Debug.Log("light1active is 1");
            startTime = Time.time;

            Debug.Log(startTime);
            Debug.Log(deltaTime);
        }

        //将物体点亮
        if((light1Active == 1)&& (Time.time > startTime+deltaTime) && (relativeThingActive == 0))//解锁之后经过短暂的时间
        {
            Debug.Log("its time to active");
            light1lMode.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject1.GetComponent<key1>().key1Active = 1;
            setActiveObject2.GetComponent<key2>().key2Active = 1;
            setActiveObject3.GetComponent<wall1>().wall1Active = 1;
            setActiveObject4.GetComponent<wall4>().wall4Active = 1;
            setActiveObject5.GetComponent<wall5>().wall5Active = 1;
            setActiveObject6.GetComponent<wall6>().wall6Active = 1;
            setActiveObject7.GetComponent<wall7>().wall7Active = 1;
            setActiveObject8.GetComponent<gear1>().gear1Active = 1;

            GetComponent<AudioSource>().enabled = true;

            relativeThingActive = 1;//防止在点亮之后还会一直check，浪费性能
        }
        
    }
}
