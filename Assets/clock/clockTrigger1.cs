using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockTrigger1 : MonoBehaviour
{


    public int[] keyNumber = new int[4] { 3, 3, 3, 3 };//在这里赋值没有用！！！



    public GameObject pointer;
    public int antiRoll = 0;
    public float startTime = 0;
    public float deltaTime = 8f;
    public float divideDeltaTime = 2f;

    public int gotPlay1 = 0;//防重复机制
    public int gotPlay2 = 0;
    public int gotPlay3 = 0;
    public int gotPlay4 = 0;

    public GameObject keyTrigger11;
    public GameObject keyTrigger12;
    public GameObject keyTrigger13;
    public GameObject keyTrigger14;



    public void playKey(int idx)
    {
        if(keyNumber[idx] == 11)
        {
            Debug.Log("play11");
            keyTrigger11.GetComponent<AudioSource>().Play();
        }

        if (keyNumber[idx] == 12)
        {
            Debug.Log("play12");
            keyTrigger12.GetComponent<AudioSource>().Play();
        }

        if (keyNumber[idx] == 13)
        {
            Debug.Log("play13");
            keyTrigger13.GetComponent<AudioSource>().Play();
        }

        if (keyNumber[idx] == 14)
        {
            Debug.Log("play14");
            keyTrigger14.GetComponent<AudioSource>().Play();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        keyNumber = new int[4] { 0, 0, 0, 0 };
        pointer = GameObject.Find("clock1Pointer");
        keyTrigger11 = GameObject.Find("keyTrigger11");
        keyTrigger12 = GameObject.Find("keyTrigger12");
        keyTrigger13 = GameObject.Find("keyTrigger13");
        keyTrigger14 = GameObject.Find("keyTrigger14");

    }

    // Update is called once per frame
    void Update()
    {
        if(antiRoll == 1 && Time.time < startTime+deltaTime )//控制指针旋转
        {
            pointer.transform.Rotate(new Vector3(0, 0, 1), 100f * Time.deltaTime);
        }

        if(antiRoll == 1 && gotPlay1 == 0 && Time.time >startTime + divideDeltaTime )
        {
            playKey(0);
            gotPlay1 = 1;
        }

        if (antiRoll == 1 && gotPlay2 == 0 && Time.time > startTime + 2*divideDeltaTime)
        {
            playKey(1);
            gotPlay2 = 1;
        }

        if (antiRoll == 1 && gotPlay3 == 0 && Time.time > startTime + 3 * divideDeltaTime)
        {
            playKey(2);
            gotPlay3 = 1;
        }

        if (antiRoll == 1 && gotPlay4 == 0 && Time.time > startTime + 4 * divideDeltaTime)
        {
            playKey(3);
            gotPlay4 = 1;
        }


        if ((antiRoll == 1) && (Time.time > startTime+deltaTime))//停止逆转
        {
            if(keyNumber[0] == 11 && keyNumber[1] == 14 && keyNumber[2] == 13 && keyNumber[3] == 12)
            {
                Debug.Log("unlock!");
                //music

                GameObject.Find("gear2d").GetComponent<gear2>().gear2Active = 1;
                GameObject.Find("gearTrigger2").GetComponent<gearTrigger2>().gearActive = 1;
            }


            Debug.Log("stop");
            antiRoll = 0; //初始机制复位
            keyNumber[0] = 0;
            keyNumber[1] = 0;
            keyNumber[2] = 0;
            keyNumber[3] = 0;
            startTime = 0;//防重复机制复位
            gotPlay1 = 0;
            gotPlay2 = 0;
            gotPlay3 = 0;
            gotPlay4 = 0;

            
        }

    }

    public void OnMouseDown()
    {
        Debug.Log("click!");
        GetComponent<AudioSource>().Play();
        
        if(keyNumber[3] == 0)//初始条件
        {
            Debug.Log("keynum=0");
            //music
        }
        else
        {
            if(startTime == 0)//防重复机制
            {
                Debug.Log("roll!!");
                antiRoll = 1;
                startTime = Time.time;
            }
           
        }
        
    }

}
