using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkeyTrigger26 : MonoBehaviour
{
    public int pkeyTrigger26Active;
    public GameObject lightcontroller;
    public plight15controller anything;
    //public int lock31;
    // Start is called before the first frame update
    void Start()
    {
        pkeyTrigger26Active = 0;
        lightcontroller = GameObject.Find("plight15controller");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)//别忘了2d！！
    {

        pkeyTrigger26Active = 1;
        anything.keyorder15[5] = anything.keyorder15[4];
        anything.keyorder15[4] = anything.keyorder15[3];
        anything.keyorder15[3] = anything.keyorder15[2];//将keyorder的数据向后推
        anything.keyorder15[2] = anything.keyorder15[1];
        anything.keyorder15[1] = anything.keyorder15[0];
        anything.keyorder15[0] = 26;
        GetComponent<AudioSource>().Play();
        Debug.Log("pkeytrigger26 is 1");
    }
}
