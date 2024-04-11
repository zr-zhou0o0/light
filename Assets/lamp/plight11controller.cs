using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plight11controller : MonoBehaviour
{
    public GameObject trigger;
    public int pLock = 0;
    public int plight11Active = 0;
    public int relativeThingActive = 0;
    private float deltaTime = 0.5f;//�ӽ����������������ʱ��
    private float startTime = 0f;

    //������Щ��Ϸ��������յ�ƿ��Ƶ�
    public GameObject light11lMode;
    public GameObject setActiveObject1;
    public GameObject setActiveObject2;
    public GameObject setActiveObject3;
    public GameObject setActiveObject4;//ʣ�¼��������ŵ�ǽ�ͳ���
    public GameObject setActiveObject5;
    public GameObject setActiveObject6;
    public GameObject setActiveObject7;
    public pwall15 anything;



    // Start is called before the first frame update
    void Start()
    {
        //��ʼ�����ҵ�����������
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
        //�鿴�ǲ����Ѿ�����
        if (pLock == 0)
        {
            pLock = trigger.GetComponent<pkeyTrigger14>().plock14;
        }

        //�Ƶ�״̬�ĳɼ���
        if ((pLock == 1) && (startTime == 0f))
        {
            plight11Active = 1;
            Debug.Log("light11active is 1");
            startTime = Time.time;

            Debug.Log(startTime);
            Debug.Log(deltaTime);
        }

        //���������
        if ((plight11Active == 1) && (Time.time > startTime + deltaTime) && (relativeThingActive == 0))//����֮�󾭹����ݵ�ʱ��
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

            relativeThingActive = 1;//��ֹ�ڵ���֮�󻹻�һֱcheck���˷�����
        }

    }
}
