using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkeyTrigger24 : MonoBehaviour
{
    public int pkeyTrigger24Active;
    public GameObject lightcontroller;
    public plight15controller anything;
    //public int lock31;
    // Start is called before the first frame update
    void Start()
    {
        pkeyTrigger24Active = 0;
        lightcontroller = GameObject.Find("plight15controller");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)//别忘了2d！！
    {

        pkeyTrigger24Active = 1;
        anything.keyorder15[5] = anything.keyorder15[4];
        anything.keyorder15[4] = anything.keyorder15[3];
        anything.keyorder15[3] = anything.keyorder15[2];//将keyorder的数据向后推
        anything.keyorder15[2] = anything.keyorder15[1];
        anything.keyorder15[1] = anything.keyorder15[0];
        anything.keyorder15[0] = 24;    //把第一个keynumber的数据修改成琴键序号
        GetComponent<AudioSource>().Play();
        Debug.Log("pkeytrigger24 is 1");
    }
}
