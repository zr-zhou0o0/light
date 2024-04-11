using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spotTrigger1 : MonoBehaviour
{
    public GameObject spot;
    public GameObject player;
    public GameObject lamp;
    public int spotActive = 0;
    public float moveSpeed = 2f;
    public int startMove = 0;

    public GameObject field;



    // Start is called before the first frame update
    void Start()
    {
        spot = GameObject.Find("spot1");
        player = GameObject.Find("backpack");
        lamp = GameObject.Find("light3d");
        field = GameObject.Find("field1d");
        spot.GetComponent<ParticleSystem>().Stop();
    }

    // Update is called once per frame
    void Update()
    {
        //灯亮之后：可见，激活
        if(lamp.GetComponent<light3controller>().relativeThingActive == 1 && spotActive==0 )
        {
            spotActive = 1;
            spot.GetComponent<ParticleSystem>().Play();
        }


        if(startMove == 1 )
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, moveSpeed * Time.deltaTime);

        }

        if(field.GetComponent<field1d>().field1Active == 1)
        {
            spot.GetComponent<ParticleSystem>().Stop();
            spotActive = 0;
        }
        
        
    }

    private void OnMouseDown()
    {
        Debug.Log("click");//点击之后：开始跑
        if(spotActive == 1)
        {
            startMove = 1;
        }

    }

}
