using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkey17d : MonoBehaviour
{
    public GameObject pkey17lMode;     //定义
    public int pkey17Active = 0;
    public int relativethingActive = 0;
    // Start is called before the first frame update
    void Start()
    {
        pkey17lMode = GameObject.Find("pkey17l");    //发现pkey17l
    }

    // Update is called once per frame
    void Update()
    {
        if ((pkey17Active == 1) && (relativethingActive == 0))   //pkey17被激活
        {
            Debug.Log("pkey17l is light!");
            pkey17lMode.GetComponent<SpriteRenderer>().enabled = true;  //打开渲染器
            relativethingActive = 1;
        }
    }
}
