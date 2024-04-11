using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class starting : MonoBehaviour
{
    public float transparent = 1;
    public float transparentplayer = 0.5f;
    public float starttime = -10;
    public GameObject curtain1;
    public GameObject curtain2;
    public GameObject square;


    // Start is called before the first frame update
    void Start()
    {
        curtain1 = GameObject.Find("curtain1");
        curtain2 = GameObject.Find("curtain2");
        square = GameObject.Find("square");
        curtain1.GetComponent<Image>().enabled = true;

        GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, 0.5f);
        curtain1.GetComponent<Image>().color = new Vector4(1f, 1f, 1f, 1);
        curtain2.GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, 1);
        square.GetComponent<SpriteRenderer>().color = new Vector4(1f, 0.8f, 0.4f, 1);

        starttime = Time.time;

        Debug.Log("finishstart");
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > starttime && Time.time < starttime + 2f)
        {
            Debug.Log("switching...");
            transparent -= 1f * Time.deltaTime;
            transparentplayer -= 0.5f * Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, transparentplayer);
            curtain1.GetComponent<Image>().color = new Vector4(1f, 1f, 1f, transparent);
            curtain2.GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, transparent);
            square.GetComponent<SpriteRenderer>().color = new Vector4(1f, 0.8f, 0.4f, transparent);
        }

        if (Time.time > starttime + 2f && Time.time < starttime + 2.2f)//防止后面没办法把它再变成true
        {
            curtain1.GetComponent<Image>().enabled = false;
        }
    }
}
