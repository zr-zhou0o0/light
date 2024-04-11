using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//用ui必须引入这个命名空间！！！！！！！

public class loading : MonoBehaviour
{
    public int loadingatv = 0;//1=无小人的黑幕 2=小人右走的黑幕 3=小人左走的黑幕
    public float transparent = 0;
    public float transparentplayer = 0;
    public GameObject curtain1;
    public GameObject curtain2;
    public GameObject square;
    public GameObject exiting;
    

    // Start is called before the first frame update
    void Start()
    {
        curtain1 = GameObject.Find("curtain1");
        curtain2 = GameObject.Find("curtain2");
        square = GameObject.Find("square");
        exiting = GameObject.Find("exiting");

        GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, 0);
        exiting.GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, 0);
        curtain1.GetComponent<Image>().color = new Vector4(1f, 1f, 1f, 0);
        curtain2.GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, 0);
        square.GetComponent<SpriteRenderer>().color = new Vector4(1f, 0.8f, 0.4f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (loadingatv == 1)//无小人
        {
            curtain1.GetComponent<Image>().enabled = true;
            if(transparentplayer < 0.5) transparentplayer += 1f * Time.deltaTime;
            transparent += 1.5f * Time.deltaTime;
            curtain1.GetComponent<Image>().color = new Vector4(1f, 1f, 1f, transparent);
            curtain2.GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, transparent);
        }

        if (loadingatv == 2)//小人右走
        {
            curtain1.GetComponent<Image>().enabled = true;
            if (transparentplayer < 0.5) transparentplayer += 1f * Time.deltaTime;
            transparent += 1.5f * Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, transparentplayer);
            curtain1.GetComponent<Image>().color = new Vector4(1f, 1f, 1f, transparent);
            curtain2.GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, transparent);
            square.GetComponent<SpriteRenderer>().color = new Vector4(1f, 0.8f, 0.4f, transparent);
        }

        if (loadingatv == 3)//小人左走
        {
            curtain1.GetComponent<Image>().enabled = true;
            if (transparentplayer < 0.5) transparentplayer += 1f * Time.deltaTime;
            transparent += 1.5f * Time.deltaTime;
            exiting.GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, transparentplayer);
            curtain1.GetComponent<Image>().color = new Vector4(1f, 1f, 1f, transparent);
            curtain2.GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, transparent);
            square.GetComponent<SpriteRenderer>().color = new Vector4(1f, 0.8f, 0.4f, transparent);
        }

    }
}
