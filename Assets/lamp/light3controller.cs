using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light3controller : MonoBehaviour
{
    public GameObject trigger;
    public int lock3 = 0;
    public int light3Active = 0;
    public int relativeThingActive = 0;
    private float deltaTime = 0.5f;//�ӽ����������������ʱ��
    private float startTime = 0f;

    //������Щ��Ϸ��������յ�ƿ��Ƶ�
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
        //��ʼ�����ҵ�����������
        trigger = GameObject.Find("keyTrigger10");
        light3lMode = GameObject.Find("light3l");
        setActiveObject1 = GameObject.Find("key8d");
        setActiveObject2 = GameObject.Find("key9d");
        setActiveObject3 = GameObject.Find("key10d");
        //������active ����ֱ��enable
        setActiveObject4 = GameObject.Find("wall14l");
        setActiveObject5 = GameObject.Find("wall15l");
        setActiveObject6 = GameObject.Find("wall16l");
       
        //�����
        setActiveObject7 = GameObject.Find("wall13d_move");
        setActiveObject8 = GameObject.Find("clock1d");


    }

    // Update is called once per frame
    void Update()
    {
        //�鿴�ǲ����Ѿ�����
        if (lock3 == 0)
        {
            lock3 = trigger.GetComponent<keyTrigger10>().lock3;
        }

        //�Ƶ�״̬�ĳɼ���
        if ((lock3 == 1) && (startTime == 0f))
        {
            light3Active = 1;
            Debug.Log("light3active is 1");
            startTime = Time.time;

            Debug.Log(startTime);
            Debug.Log(deltaTime);
        }

        //���������
        if ((light3Active == 1) && (Time.time > startTime + deltaTime) && (relativeThingActive == 0))//����֮�󾭹����ݵ�ʱ��
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

            relativeThingActive = 1;//��ֹ�ڵ���֮�󻹻�һֱcheck���˷�����
        }

    }
}
