using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light4controller : MonoBehaviour
{
    public GameObject trigger;
    public int lock5 = 0;
    public int light4Active = 0;
    public int relativeThingActive = 0;
    private float deltaTime = 0.5f;//从解锁（激活）到变亮的时间
    private float startTime = 0f;

    //以下这些游戏物体是这盏灯控制的
    public GameObject light4lMode;
    public GameObject setActiveObject1;
    public GameObject setActiveObject2;
    public GameObject setActiveObject3;
    public GameObject setActiveObject4;
    public GameObject setActiveObject5;
    public GameObject setActiveObject6;
    public GameObject setActiveObject7;
    public GameObject setActiveObject8;
    public GameObject setActiveObject9;
    public GameObject setActiveObject10;
    public GameObject setActiveObject11;


    // Start is called before the first frame update
    void Start()
    {
        //初始化：找到关联的物体
        trigger = GameObject.Find("keyTrigger15");
        light4lMode = GameObject.Find("light4l");
        setActiveObject1 = GameObject.Find("key15d");
        setActiveObject2 = GameObject.Find("gear4d");
       
        //以上用active 以下直接enable
        setActiveObject4 = GameObject.Find("wall3l");
        setActiveObject5 = GameObject.Find("wall22l");
        setActiveObject6 = GameObject.Find("wall23l");
        setActiveObject7 = GameObject.Find("wall24l");
        setActiveObject8 = GameObject.Find("wall25l");

    }

    // Update is called once per frame
    void Update()
    {
        //查看是不是已经解锁
        if (lock5 == 0)
        {
            lock5 = trigger.GetComponent<keyTrigger15>().lock5;
        }

        //灯的状态改成激活
        if ((lock5 == 1) && (startTime == 0f))
        {
            light4Active = 1;
            Debug.Log("light4active is 1");
            startTime = Time.time;

            Debug.Log(startTime);
            Debug.Log(deltaTime);
        }

        //将物体点亮
        if ((light4Active == 1) && (Time.time > startTime + deltaTime) && (relativeThingActive == 0))//解锁之后经过短暂的时间
        {
            Debug.Log("its time to active");
            light4lMode.GetComponent<SpriteRenderer>().enabled = true;
            //
            setActiveObject1.GetComponent<key15>().key15Active = 1;
            setActiveObject2.GetComponent<gear4>().gear4Active = 1;
           


            setActiveObject4.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject5.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject6.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject7.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject8.GetComponent<SpriteRenderer>().enabled = true;


            GetComponent<AudioSource>().enabled = true;//
            GetComponent<AudioSource>().Play();

            relativeThingActive = 1;//防止在点亮之后还会一直check，浪费性能
        }

    }
}
