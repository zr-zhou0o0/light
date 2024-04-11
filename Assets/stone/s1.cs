using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s1 : MonoBehaviour
{
    public int s1atv = 0;//atv是active的意思
    public float transparent = 0;

    public int[] stoneNumber = new int[3] { 3, 3, 3 };//在这里赋值没有用！
    public int s1lock = 0;

    // Start is called before the first frame update
    void Start()
    {
        stoneNumber = new int[3] { 0, 0, 0 };
        GetComponent<SpriteRenderer>().color = new Vector4(255, 255f, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (s1atv == 1)
        {
            transparent += 1f * Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Vector4(255, 255f, 255, transparent);
        }

        if(stoneNumber[0] == 1 && stoneNumber[1] == 2 && stoneNumber[2] == 1)
        {
           // Debug.Log("unlock!");
            s1lock = 1;
            GameObject.Find("fl1").GetComponent<flower1>().flower1atv = 1;
            GameObject.Find("fl2").GetComponent<flower2>().flower2atv = 1;
            GameObject.Find("wf1").GetComponent<wf1>().wf1atv= 1;
            GameObject.Find("wf2").GetComponent<wf2>().wf2atv = 1;
            GameObject.Find("wf3").GetComponent<wf3>().wf3atv = 1;
            GameObject.Find("d1").GetComponent<d1>().d1atv = 1;

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collide!");
        s1atv = 1;

        GetComponent<AudioSource>().Play();

        stoneNumber[2] = stoneNumber[1];
        stoneNumber[1] = stoneNumber[0];
        stoneNumber[0] = 1;


    }

}
