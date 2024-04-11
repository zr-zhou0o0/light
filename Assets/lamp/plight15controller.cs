using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plight15controller : MonoBehaviour
{
    public GameObject trigger;
    public int plight15Active = 0;          //灯的状态为不活跃
    public int relativeThingActive = 0;
    public int[] keyorder15 = new int[6];//储存琴键顺序的数组

    //以下这些游戏物体是这盏灯控制的
    public GameObject plight15lMode;
    public GameObject setActiveObject1;
    public GameObject setActiveObject2;
    public GameObject setActiveObject3;
    public GameObject setActiveObject4;
    public int setActiveObject5;
    void Start()
    {
        plight15lMode = GameObject.Find("plight15l");
        setActiveObject1 = GameObject.Find("pkey24d");  //找到暗着的琴键
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
            setActiveObject4.GetComponent<SpriteRenderer>().enabled = true;//直接把plight12的渲染器打开       
            setActiveObject5 = 1;                 //打开pkey20
            GetComponent<AudioSource>().enabled = true;
        }
        relativeThingActive = 1;//防止在点亮之后还会一直check，浪费性能
    }
}
