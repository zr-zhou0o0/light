using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plight15controller : MonoBehaviour
{
    public GameObject trigger;
    public int plight15Active = 0;          //�Ƶ�״̬Ϊ����Ծ
    public int relativeThingActive = 0;
    public int[] keyorder15 = new int[6];//�����ټ�˳�������

    //������Щ��Ϸ��������յ�ƿ��Ƶ�
    public GameObject plight15lMode;
    public GameObject setActiveObject1;
    public GameObject setActiveObject2;
    public GameObject setActiveObject3;
    public GameObject setActiveObject4;
    public int setActiveObject5;
    void Start()
    {
        plight15lMode = GameObject.Find("plight15l");
        setActiveObject1 = GameObject.Find("pkey24d");  //�ҵ����ŵ��ټ�
        setActiveObject2 = GameObject.Find("pkey25d");
        setActiveObject3 = GameObject.Find("pkey26d");
        setActiveObject4 = GameObject.Find("pwall20l");
        setActiveObject5 = 0;
        //Debug.Log("asdfg")
        keyorder15 = new int[6] { 0, 0, 0, 0, 0, 0 };
    }

    // Update is called once per frame
    void Update()
    {
        if ((keyorder15[0] == 26) && (keyorder15[1] == 25) && (keyorder15[2] == 24) && (keyorder15[3] == 26) && (keyorder15[4] == 25) && (keyorder15[5] == 24))
        {
            Debug.Log("its time to active");
            setActiveObject5 = 1;
            plight15lMode.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject4.GetComponent<SpriteRenderer>().enabled = true;//ֱ�Ӱ�plight12����Ⱦ����       
            setActiveObject5 = 1;                 //��pkey20
            GetComponent<AudioSource>().enabled = true;
        }
        relativeThingActive = 1;//��ֹ�ڵ���֮�󻹻�һֱcheck���˷�����
    }
}
