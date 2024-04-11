using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altarla1d : MonoBehaviour
{
    public GameObject spot;
    public GameObject spotTrigger;
    // public GameObject lamp;
    public int spotReady = 0;
    //public int lampReady = 0;
    public int startMove = 0;
    public float moveSpeed = 4f;//两个速度在拉扯

    public int altarla1Active = 0;
    public GameObject altarlalMode;

    public GameObject altarla2;
    public GameObject altarla2l;

    public GameObject musicOff;

    public GameObject player;
   

    // Start is called before the first frame update
    void Start()
    {
        spot = GameObject.Find("spot2");
        spotTrigger = GameObject.Find("spotTrigger2");
        altarlalMode = GameObject.Find("altarla1l");
        altarla2 = GameObject.Find("altarla2d");
        altarla2l = GameObject.Find("altarla2l");

        musicOff = GameObject.Find("enterTrigger6");

        player = GameObject.Find("role0");
      
        // lamp = GameObject.Find("light3d");
    }

    // Update is called once per frame
    void Update()
    {
        spotReady = spotTrigger.GetComponent<spotTrigger2>().startMove;
        //lampReady = lamp.GetComponent<light3controller>().light3Active;
        if (startMove == 1)
        {
            //看函数说明，第一个是current，第二个是target
            spotTrigger.transform.position = Vector3.MoveTowards(spotTrigger.transform.position, this.transform.position, moveSpeed * Time.deltaTime);
        }


        if (spotTrigger.transform.position.x - this.transform.position.x < 0.1 && spotTrigger.transform.position.y - this.transform.position.y < 0.1)
        {
            startMove = 0;
            altarla1Active = 1;
        }


        if (altarla1Active == 1)
        {
            altarlalMode.GetComponent<SpriteRenderer>().enabled = true;


            //为什么这两条不管用？？？
            spotTrigger.GetComponent<spotTrigger2>().spotActive = 0;//点亮后光就消失了
            spot.GetComponent<ParticleSystem>().Stop();

           
        }


    }

    private void OnMouseDown()
    {
        Debug.Log("click");
        if (spotReady == 1)
        {
            startMove = 1;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(altarla1Active == 1)
        {
            Debug.Log("gotosky2");
            GameObject.Find("curtain").GetComponent<curtains1>().win = 1;
           // player.transform.position = new Vector3(-4.61f, -1.88f, 0);
            //altarla2.GetComponent<altarla2>.altarla2Active = 1;
           // altarla2l.GetComponent<SpriteRenderer>().enabled = true;

           // musicOff.GetComponent<AudioSource>().Stop();
        }
    }




}
