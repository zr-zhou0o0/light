using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altarla7 : MonoBehaviour
{
    public GameObject spot;
    public GameObject spotTrigger;
    public int spotReady = 0;

    public int startMove = 0;
    public float moveSpeed = 4f;//两个速度在拉扯

    public int altarla7Active = 0;
    public GameObject altarlalMode;

    public GameObject player;

    public float transparent = 0;

    // Start is called before the first frame update
    void Start()
    {
        spot = GameObject.Find("spot3");
        spotTrigger = GameObject.Find("spotTrigger3");
        altarlalMode = GameObject.Find("altarla7l");

        player = GameObject.Find("role0");
    }

    // Update is called once per frame
    void Update()
    {
        spotReady = spotTrigger.GetComponent<spotTrigger3>().startMove;
        if (startMove == 1)
        {
            //看函数说明，第一个是current，第二个是target
            spotTrigger.transform.position = Vector3.MoveTowards(spotTrigger.transform.position, this.transform.position, moveSpeed * Time.deltaTime);
        }

        if (spotTrigger.transform.position.x - this.transform.position.x < 0.1 && spotTrigger.transform.position.y - this.transform.position.y < 0.1)
        {
            startMove = 0;
            altarla7Active = 1;
        }

        if (altarla7Active == 1)
        {
            //altarlalMode.GetComponent<SpriteRenderer>().enabled = true;
            transparent += 1f * Time.deltaTime;
            altarlalMode.GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, transparent);

            //为什么这两条不管用？？？
           // spotTrigger.GetComponent<spotTrigger2>().spotActive = 0;//点亮后光就消失了
           // spot.GetComponent<ParticleSystem>().Stop();


        }

    }

    public void OnMouseDown()
    {
        Debug.Log("click");
        if (spotReady == 1)
        {
            startMove = 1;
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (altarla7Active == 1)
        {
            Debug.Log("winwinwin");
            GameObject.Find("curtain").GetComponent<curtainf>().win = 1;
        }
    }

}
