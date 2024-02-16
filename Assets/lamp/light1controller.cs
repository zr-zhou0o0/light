using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light1controller : MonoBehaviour
{
    public GameObject trigger;
    public int Lock = 0;
    public int light1Active = 0;
    public int relativeThingActive = 0;
    private float deltaTime = 0.5f;//�ӽ����������������ʱ��
    private float startTime = 0f;

    //������Щ��Ϸ��������յ�ƿ��Ƶ�
    public GameObject light1lMode;
    public GameObject setActiveObject1;
    public GameObject setActiveObject2;
    public GameObject setActiveObject3;
    public GameObject setActiveObject4;//ʣ�¼��������ŵ�ǽ�ͳ���
    public GameObject setActiveObject5;
    public GameObject setActiveObject6;
    public GameObject setActiveObject7;
    public GameObject setActiveObject8;//����


    // Start is called before the first frame update
    void Start()
    {
        //��ʼ�����ҵ�����������
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
        //�鿴�ǲ����Ѿ�����
        if (Lock == 0)
        {
            Lock = trigger.GetComponent<keyTrigger1>().lock1;
        }

        //�Ƶ�״̬�ĳɼ���
        if((Lock==1) && (startTime==0f))
        {
            light1Active = 1;
            Debug.Log("light1active is 1");
            startTime = Time.time;

            Debug.Log(startTime);
            Debug.Log(deltaTime);
        }

        //���������
        if((light1Active == 1)&& (Time.time > startTime+deltaTime) && (relativeThingActive == 0))//����֮�󾭹����ݵ�ʱ��
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

            relativeThingActive = 1;//��ֹ�ڵ���֮�󻹻�һֱcheck���˷�����
        }
        
    }
}
