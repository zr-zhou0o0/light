using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light3controller : MonoBehaviour
{
    public GameObject trigger;
    public int lock3 = 0;
    public int light3Active = 0;
    public int relativeThingActive = 0;
    private float deltaTime = 0.5f;//从解锁（激活）到变亮的时间
    private float startTime = 0f;

    //以下这些游戏物体是这盏灯控制的
    public GameObject light3lMode;
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
        trigger = GameObject.Find("keyTrigger10");
        light3lMode = GameObject.Find("light3l");
        setActiveObject1 = GameObject.Find("key8d");
        setActiveObject2 = GameObject.Find("key9d");
        setActiveObject3 = GameObject.Find("key10d");
        //以上用active 以下直接enable
        setActiveObject4 = GameObject.Find("wall14l");
        setActiveObject5 = GameObject.Find("wall15l");
        setActiveObject6 = GameObject.Find("wall16l");
       
        //特殊的
        setActiveObject7 = GameObject.Find("wall13d_move");
        setActiveObject8 = GameObject.Find("clock1d");


    }

    // Update is called once per frame
    void Update()
    {
        //查看是不是已经解锁
        if (lock3 == 0)
        {
            lock3 = trigger.GetComponent<keyTrigger10>().lock3;
        }

        //灯的状态改成激活
        if ((lock3 == 1) && (startTime == 0f))
        {
            light3Active = 1;
            Debug.Log("light3active is 1");
            startTime = Time.time;

            Debug.Log(startTime);
            Debug.Log(deltaTime);
        }

        //将物体点亮
        if ((light3Active == 1) && (Time.time > startTime + deltaTime) && (relativeThingActive == 0))//解锁之后经过短暂的时间
        {
            Debug.Log("its time to active");
            light3lMode.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject1.GetComponent<key8>().key8Active = 1;
            setActiveObject2.GetComponent<key9>().key9Active = 1;
            setActiveObject3.GetComponent<key10>().key10Active = 1;

            setActiveObject7.GetComponent<wall13>().wall13Active = 1;//
            setActiveObject8.GetComponent<clock1>().clock1Active = 1;//


            setActiveObject4.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject5.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject6.GetComponent<SpriteRenderer>().enabled = true;
            

            GetComponent<AudioSource>().enabled = true;//
            GetComponent<AudioSource>().Play();

            relativeThingActive = 1;//防止在点亮之后还会一直check，浪费性能
        }

    }
}
