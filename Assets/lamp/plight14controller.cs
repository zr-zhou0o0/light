using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class plight14controller : MonoBehaviour
{
    public GameObject trigger;
    public int plight12Active = 0;          //�Ƶ�״̬Ϊ����Ծ
    public int relativeThingActive = 0;
    public int[] keyorder14 = new int[5];//�����ټ�˳�������

    //������Щ��Ϸ��������յ�ƿ��Ƶ�
    public GameObject plight14lMode;
    public GameObject setActiveObject1;
    public GameObject setActiveObject2;
    public GameObject setActiveObject3;
    public GameObject setActiveObject4;
    public int setActiveObject5;
    void Start()
    {
        plight14lMode = GameObject.Find("plight14l");
        setActiveObject1 = GameObject.Find("pkey18d");  //�ҵ����ŵ��ټ�
        setActiveObject2 = GameObject.Find("pkey19d");
        setActiveObject3 = GameObject.Find("pkey17d");
        setActiveObject4 = GameObject.Find("pwall23l");
        setActiveObject5 = 0;
        //Debug.Log("asdfg")
        keyorder14 = new int[5] { 0, 0, 0, 0, 0 };
    }

    // Update is called once per frame
    void Update()
    {
        if ((keyorder14[0] == 20) && (keyorder14[1] == 18) && (keyorder14[2] == 20) && (keyorder14[3] == 19) && (keyorder14[4] == 18))
        {
            Debug.Log("its time to active");
            setActiveObject5 = 1;
            plight14lMode.GetComponent<SpriteRenderer>().enabled = true;
            setActiveObject4.GetComponent<SpriteRenderer>().enabled = true;//ֱ�Ӱ�plight12����Ⱦ����                       //��pkey20
            GetComponent<AudioSource>().enabled = true;
        }
        relativeThingActive = 1;//��ֹ�ڵ���֮�󻹻�һֱcheck���˷�����
    }
}
