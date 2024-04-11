using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light4controller : MonoBehaviour
{
    public GameObject trigger;
    public int lock5 = 0;
    public int light4Active = 0;
    public int relativeThingActive = 0;
    private float deltaTime = 0.5f;//�ӽ����������������ʱ��
    private float startTime = 0f;

    //������Щ��Ϸ��������յ�ƿ��Ƶ�
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
        //��ʼ�����ҵ�����������
        trigger = GameObject.Find("keyTrigger15");
        light4lMode = GameObject.Find("light4l");
        setActiveObject1 = GameObject.Find("key15d");
        setActiveObject2 = GameObject.Find("gear4d");
       
        //������active ����ֱ��enable
        setActiveObject4 = GameObject.Find("wall3l");
        setActiveObject5 = GameObject.Find("wall22l");
        setActiveObject6 = GameObject.Find("wall23l");
        setActiveObject7 = GameObject.Find("wall24l");
        setActiveObject8 = GameObject.Find("wall25l");

    }

    // Update is called once per frame
    void Update()
    {
        //�鿴�ǲ����Ѿ�����
        if (lock5 == 0)
        {
            lock5 = trigger.GetComponent<keyTrigger15>().lock5;
        }

        //�Ƶ�״̬�ĳɼ���
        if ((lock5 == 1) && (startTime == 0f))
        {
            light4Active = 1;
            Debug.Log("light4active is 1");
            startTime = Time.time;

            Debug.Log(startTime);
            Debug.Log(deltaTime);
        }

        //���������
        if ((light4Active == 1) && (Time.time > startTime + deltaTime) && (relativeThingActive == 0))//����֮�󾭹����ݵ�ʱ��
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

            relativeThingActive = 1;//��ֹ�ڵ���֮�󻹻�һֱcheck���˷�����
        }

    }
}
