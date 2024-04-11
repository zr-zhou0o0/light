using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light2controller : MonoBehaviour
{
    public GameObject trigger;
    public int lock2 = 0;
    public int light2Active = 0;
    public int relativeThingActive = 0;
    private float deltaTime = 0.5f;//从解锁（激活）到变亮的时间
    private float startTime = 0f;

    //以下这些游戏物体是这盏灯控制的
    public GameObject light2lMode;
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
        trigger = GameObject.Find("keytrigger6");
        light2lMode = GameObject.Find("light2l");
        setActiveObject1 = GameObject.Find("key5d");
        setActiveObject2 = GameObject.Find("key6d");
        setActiveObject3 = GameObject.Find("key7d");
        //以上用active 以下直接enable
        setActiveObject4 = GameObject.Find("wall9l");
        setActiveObject5 = GameObject.Find("wall10l");
        setActiveObject6 = GameObject.Find("wall11l");
        setActiveObject7 = GameObject.Find("wall12l");
        //特殊的
        setActiveObject8 = GameObject.Find("wall11d");
        
       
    }

    // Update is called once per frame
    void Update()
    {
        //查看是不是已经解锁
        if (lock2 == 0)
        {
            lock2 = trigger.GetComponent<keyTrigger6>().lock2;
        }

        //灯的状态改成激活
        if ((lock2 == 1) && (startTime == 0f))
        {
            light2Active = 1;
            Debug.Log("light2active is 1");
            startTime = Time.time;

            Debug.Log(startTime);
            Debug.Log(deltaTime);
        }

        //将物体点亮
        if ((light2Active == 1) && (Time.time > startTime + deltaTime) && (relativeThingActive == 0))//解锁之后经过短暂的时间
        {
            Debug.Log("its time to active");
            light2lMode.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject1.GetComponent<key5>().key5Active = 1;
            setActiveObject2.GetComponent<key6>().key6Active = 1;
            setActiveObject3.GetComponent<key7>().key7Active = 1;
            setActiveObject8.GetComponent<wall11>().wall11Active = 1;
       

            setActiveObject4.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject5.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject6.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject7.GetComponent<SpriteRenderer>().enabled = true;

            GetComponent<AudioSource>().enabled = true;

            relativeThingActive = 1;//防止在点亮之后还会一直check，浪费性能
        }

    }
}
