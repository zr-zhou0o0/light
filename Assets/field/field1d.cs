using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class field1d : MonoBehaviour
{
    public GameObject spot;
    public GameObject spotTrigger;
   // public GameObject lamp;
    public int spotReady = 0;
    //public int lampReady = 0;
    public int startMove = 0;
    public float moveSpeed = 4f;//两个速度在拉扯

    public int field1Active = 0;
    public GameObject fieldlMode;
    public GameObject fieldLight;//物体中间大写。脚本+“1”

    // Start is called before the first frame update
    void Start()
    {
        spot = GameObject.Find("spot1");
        spotTrigger = GameObject.Find("spotTrigger1");
        fieldlMode = GameObject.Find("field1l");
        fieldLight = GameObject.Find("fieldlight");
       // lamp = GameObject.Find("light3d");
    }

    // Update is called once per frame
    void Update()
    {
        spotReady = spotTrigger.GetComponent<spotTrigger1>().startMove;
        //lampReady = lamp.GetComponent<light3controller>().light3Active;
        if(startMove == 1)
        {
            //看函数说明，第一个是current，第二个是target
            spotTrigger.transform.position = Vector3.MoveTowards(spotTrigger.transform.position, this.transform.position, moveSpeed * Time.deltaTime);
        }

        
        if(spotTrigger.transform.position.x- this.transform.position.x < 0.1 && spotTrigger.transform.position.y - this.transform.position.y < 0.1)
        {
            startMove = 0;
            field1Active = 1;
        }
        

        if(field1Active == 1)
        {
            fieldlMode.GetComponent<SpriteRenderer>().enabled = true;


            //为什么这两条不管用？？？
            spotTrigger.GetComponent<spotTrigger1>().spotActive = 0;//点亮后光就消失了
            spot.GetComponent<ParticleSystem>().Stop();

            fieldLight.GetComponent<fieldlight1>().fieldlightActive = 1;//似乎find不到括号、下划线等
        }


    }

    private void OnMouseDown()
    {
        Debug.Log("click");
        if(spotReady == 1)
        {
            startMove = 1;
        }

    }

}
