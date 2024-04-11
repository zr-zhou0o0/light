using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spotTrigger3 : MonoBehaviour
{
    public GameObject spot;
    public GameObject player;

    public int spotActive = 0;
    public int spotActived = 0;
    public float moveSpeed = 2f;
    public int startMove = 0;

    public GameObject altarla;

    // Start is called before the first frame update
    void Start()
    {
        spot = GameObject.Find("spot3");
        player = GameObject.Find("backpack");
        altarla = GameObject.Find("altarla7");
        spot.GetComponent<ParticleSystem>().Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if(spotActive == 1 && spotActived ==0 )
        {
            spot.GetComponent<ParticleSystem>().Play();
            spotActived = 1;
        }

        if (startMove == 1)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, moveSpeed * Time.deltaTime);

        }

        if (altarla.GetComponent<altarla7>().altarla7Active == 1)
        {
            spot.GetComponent<ParticleSystem>().Stop();
            spotActive = 0;
        }

    }

    private void OnMouseDown()
    {
        Debug.Log("click");//点击之后：开始跑
        if (spotActive == 1)
        {
            startMove = 1;
        }

    }

}
