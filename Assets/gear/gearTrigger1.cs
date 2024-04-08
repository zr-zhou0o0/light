using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gearTrigger1 : MonoBehaviour
{
    public int gearTrigger1Active = 0;
    public int relativeThingActive = 0;

    public int gearActive = 0;

    public float wallStartTime = 0;
<<<<<<< HEAD
    public float wallMoveDeltaTime = 8;//ÕâÀï¸ÄÁËÓÎÏ·½Å±¾Ãæ°åÀïÒ²Òª¸Ä£¬·ñÔòÃ»ÓÃ£¡£¡£¡ÑªÀáµÄ½ÌÑµ£¡
=======
    public float wallMoveDeltaTime = 8;//ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½Ï·ï¿½Å±ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½Ò²Òªï¿½Ä£ï¿½ï¿½ï¿½ï¿½ï¿½Ã»ï¿½Ã£ï¿½ï¿½ï¿½ï¿½ï¿½Ñªï¿½ï¿½Ä½ï¿½Ñµï¿½ï¿½
>>>>>>> 413af3c (jyh first)

    public GameObject gear;
    public GameObject wall;
    

    // Start is called before the first frame update
    void Start()
    {
        gear = GameObject.Find("gear1d");
        wall = GameObject.Find("wall5d");
      

    }

    // Update is called once per frame
    void Update()
    {
        
         gearActive = gear.GetComponent<gear1>().gear1Active;
        

        if(gearTrigger1Active == 1)//&& (relativeThingActive == 0))
        {
           // Debug.Log("active gear and wall!");
<<<<<<< HEAD
            gear.transform.Rotate(new Vector3(0, 0, 1), 0.5f);//ÒªÒ»Ö±×ªµÄ»°¾Í²»ÄÜÏÞÖÆrelativethingactive£¡·ñÔòÖ»×ªÒ»Ë²¼ä£¬¿´²»³öÀ´¡£
=======
            gear.transform.Rotate(new Vector3(0, 0, 1), 0.5f);//ÒªÒ»Ö±×ªï¿½Ä»ï¿½ï¿½Í²ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½relativethingactiveï¿½ï¿½ï¿½ï¿½ï¿½ï¿½Ö»×ªÒ»Ë²ï¿½ä£¬ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½
>>>>>>> 413af3c (jyh first)
            
        }

        if((gearTrigger1Active == 1)&&(relativeThingActive == 0))
        {
            wallStartTime = Time.time;
            GetComponent<AudioSource>().Play();
            relativeThingActive = 1;
            Debug.Log(Time.time);
            Debug.Log(wallMoveDeltaTime);
            Debug.Log(Time.time + wallMoveDeltaTime);
        }

        if((Time.time > wallStartTime) && (Time.time < wallStartTime+wallMoveDeltaTime) && (relativeThingActive == 1))
        {
            wall.transform.Translate(new Vector3(0, -1, 0)*0.001f);
        }


    }

   

<<<<<<< HEAD
    public void OnMouseDown()//Òª¸øÎïÌå¼ÓÉÏcollider2dºÍ¡°ÊÇ´¥·¢Æ÷¡±Ñ¡Ïî
    {
        Debug.Log("mouse down!");
        if (gearActive == 1)//µ±³ÝÂÖÁÁ×ÅµÄÊ±ºò
=======
    public void OnMouseDown()//Òªï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½collider2dï¿½Í¡ï¿½ï¿½Ç´ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½Ñ¡ï¿½ï¿½
    {
        Debug.Log("mouse down!");
        if (gearActive == 1)//ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½Åµï¿½Ê±ï¿½ï¿½
>>>>>>> 413af3c (jyh first)
        {
            gearTrigger1Active = 1;
            Debug.Log("geartrigger1active is 1");
        }
    }

}
