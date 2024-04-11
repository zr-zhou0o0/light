using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plight12controller : MonoBehaviour
{
    public GameObject trigger;             
    public int plight12Active = 0;          //灯的状态为不活跃
    public int relativeThingActive = 0;
 //   private float deltaTime = 0.5f;//从解锁（激活）到变亮的时间
  //  private float startTime = 0f;

    //存储琴键顺序的数组
    public int[] keyorder = new int[4];

    //以下这些游戏物体是这盏灯控制的
    public GameObject plight12lMode;
    public GameObject setActiveObject1;
    public GameObject setActiveObject2;
    public GameObject setActiveObject3;
    public GameObject setActiveObject4;
    public GameObject setActiveObject5;


    // Start is called before the first frame update
    void Start()
    {
        //初始化：找到关联的物体
        plight12lMode = GameObject.Find("plight12l");
        setActiveObject1 = GameObject.Find("pkey15d");  //找到暗着的琴键
        setActiveObject2 = GameObject.Find("pkey16d");
        setActiveObject3 = GameObject.Find("pwall17d");
        setActiveObject4 = GameObject.Find("pwall18d");
        Debug.Log("asdfg");
        setActiveObject5 = GameObject.Find("pkey17d");

        //初始化琴键数组
        keyorder = new int[4] { 0, 0, 0, 0 };
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if ( startTime == 0f)
        {
            plight12Active = 1;    //灯被激活
            Debug.Log("plight12Active is 1");
            startTime = Time.time;

            Debug.Log(startTime);
            Debug.Log(deltaTime);
        }
        */
        /*
        //将物体点亮
        if ((plight12Active == 1) && (Time.time > startTime + deltaTime) && (relativeThingActive == 0))
        {
        */
            //Debug.Log("Enter loop");
            if ((keyorder[0]==16)&&(keyorder[1] == 17)&& (keyorder[2] == 17)&& (keyorder[3] == 15))
            { 
                Debug.Log("its time to active");
                plight12lMode.GetComponent<SpriteRenderer>().enabled = true;      //直接把plight12的渲染器打开
                setActiveObject1.GetComponent<pkey15>().pkey15Active = 1;
                setActiveObject2.GetComponent<pkey16>().pkey16Active = 1;         //将pkey16激活，操控pkey16渲染器打开，pkey16亮
                setActiveObject3.GetComponent<pwall17>().pwall17Active = 1;
                setActiveObject4.GetComponent<pwall18>().pwall18Active = 1;
                setActiveObject5.GetComponent<pkey17d>().pkey17Active = 1;

                GetComponent<AudioSource>().enabled = true;
            }
            relativeThingActive = 1;//防止在点亮之后还会一直check，浪费性能
        

    }
}
