using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkeyTrigger17 : MonoBehaviour
{
    public GameObject lightcontroller;
    
    // Start is called before the first frame update
    void Start()
    {
        lightcontroller = GameObject.Find("plight12d");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        lightcontroller.GetComponent<plight12controller>().keyorder[3] = lightcontroller.GetComponent<plight12controller>().keyorder[2]; //将keyorder的数据向后推
        lightcontroller.GetComponent<plight12controller>().keyorder[2] = lightcontroller.GetComponent<plight12controller>().keyorder[1];
        lightcontroller.GetComponent<plight12controller>().keyorder[1] = lightcontroller.GetComponent<plight12controller>().keyorder[0];
        lightcontroller.GetComponent<plight12controller>().keyorder[0] = 17;    //把第一个keynumber的数据修改成琴键序号

        GetComponent<AudioSource>().Play();  //琴键对应的音调响起

    }
}
