using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plight12controller : MonoBehaviour
{
    public GameObject trigger;             
    public int plight12Active = 0;          //�Ƶ�״̬Ϊ����Ծ
    public int relativeThingActive = 0;
 //   private float deltaTime = 0.5f;//�ӽ����������������ʱ��
  //  private float startTime = 0f;

    //�洢�ټ�˳�������
    public int[] keyorder = new int[4];

    //������Щ��Ϸ��������յ�ƿ��Ƶ�
    public GameObject plight12lMode;
    public GameObject setActiveObject1;
    public GameObject setActiveObject2;
    public GameObject setActiveObject3;
    public GameObject setActiveObject4;
    public GameObject setActiveObject5;


    // Start is called before the first frame update
    void Start()
    {
        //��ʼ�����ҵ�����������
        plight12lMode = GameObject.Find("plight12l");
        setActiveObject1 = GameObject.Find("pkey15d");  //�ҵ����ŵ��ټ�
        setActiveObject2 = GameObject.Find("pkey16d");
        setActiveObject3 = GameObject.Find("pwall17d");
        setActiveObject4 = GameObject.Find("pwall18d");
        Debug.Log("asdfg");
        setActiveObject5 = GameObject.Find("pkey17d");

        //��ʼ���ټ�����
        keyorder = new int[4] { 0, 0, 0, 0 };
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if ( startTime == 0f)
        {
            plight12Active = 1;    //�Ʊ�����
            Debug.Log("plight12Active is 1");
            startTime = Time.time;

            Debug.Log(startTime);
            Debug.Log(deltaTime);
        }
        */
        /*
        //���������
        if ((plight12Active == 1) && (Time.time > startTime + deltaTime) && (relativeThingActive == 0))
        {
        */
            //Debug.Log("Enter loop");
            if ((keyorder[0]==16)&&(keyorder[1] == 17)&& (keyorder[2] == 17)&& (keyorder[3] == 15))
            { 
                Debug.Log("its time to active");
                plight12lMode.GetComponent<SpriteRenderer>().enabled = true;      //ֱ�Ӱ�plight12����Ⱦ����
                setActiveObject1.GetComponent<pkey15>().pkey15Active = 1;
                setActiveObject2.GetComponent<pkey16>().pkey16Active = 1;         //��pkey16����ٿ�pkey16��Ⱦ���򿪣�pkey16��
                setActiveObject3.GetComponent<pwall17>().pwall17Active = 1;
                setActiveObject4.GetComponent<pwall18>().pwall18Active = 1;
                setActiveObject5.GetComponent<pkey17d>().pkey17Active = 1;

                GetComponent<AudioSource>().enabled = true;
            }
            relativeThingActive = 1;//��ֹ�ڵ���֮�󻹻�һֱcheck���˷�����
        

    }
}
