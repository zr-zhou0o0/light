using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light6controller : MonoBehaviour
{
    public GameObject trigger;
    public int triggerActive = 0;

    public int light6Active = 0;
    public int relativeThingActive = 0;

    private float deltaTime = 0.3f;//从解锁（激活）到变亮的时间
    private float startTime = 0f;


    public GameObject light6lMode;
    public GameObject setActiveObject1;
    public GameObject setActiveObject2;
    public GameObject setActiveObject3;
    public GameObject setActiveObject4;
    public GameObject setActiveObject5;
    public GameObject setActiveObject6;
    public GameObject setActiveObject7;
    public GameObject setActiveObject8;
    public GameObject setActiveObject9;



    // Start is called before the first frame update
    void Start()
    {
        trigger = GameObject.Find("enterTrigger4");
        light6lMode = GameObject.Find("light6l");
        setActiveObject1 = GameObject.Find("key11d");
        setActiveObject2 = GameObject.Find("key12d");
        setActiveObject3 = GameObject.Find("key13d");
        setActiveObject4 = GameObject.Find("key14d");
        setActiveObject5 = GameObject.Find("wall17l");
        setActiveObject6 = GameObject.Find("wall18l");
        setActiveObject7 = GameObject.Find("wall19l");
        setActiveObject8 = GameObject.Find("wall20l");
        setActiveObject9 = GameObject.Find("wall21l");

    }

    // Update is called once per frame
    void Update()
    {
        //查看是不是已经解锁
        if (triggerActive == 0)
        {
            triggerActive = trigger.GetComponent<room4Enter>().triggerActive;
        }

        //灯的状态改成激活
        if ((triggerActive == 1) && (startTime == 0f))
        {
            light6Active = 1;
            Debug.Log("light6active is 1");
            startTime = Time.time;

            Debug.Log(startTime);
            Debug.Log(deltaTime);
        }

        //将物体点亮
        if ((light6Active == 1) && (Time.time > startTime + deltaTime) && (relativeThingActive == 0))//解锁之后经过短暂的时间
        {
            Debug.Log("its time to active");
            light6lMode.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject1.GetComponent<key11>().key11Active = 1;
            setActiveObject2.GetComponent<key12>().key12Active = 1;
            setActiveObject3.GetComponent<key13>().key13Active = 1;
            setActiveObject4.GetComponent<key14>().key14Active = 1;


            setActiveObject5.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject6.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject7.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject8.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject9.GetComponent<SpriteRenderer>().enabled = true;

            GetComponent<AudioSource>().enabled = true;//
            GetComponent<AudioSource>().Play();

            relativeThingActive = 1;//防止在点亮之后还会一直check，浪费性能
        }


    }
}
