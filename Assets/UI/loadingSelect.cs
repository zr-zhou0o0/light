using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadingSelect : MonoBehaviour
{
    public float transparent = 0;
    public float transparentplayer = 0.5f;
    public GameObject u1;
    public GameObject u2;
    public GameObject u3;
    public GameObject u4;
    public GameObject u5;
    public GameObject u6;
    public float starttime = -10;

    // Start is called before the first frame update
    void Start()
    {
        u1 = GameObject.Find("forest");
        u2 = GameObject.Find("dreamland");
        u3 = GameObject.Find("sky");
        u4 = GameObject.Find("return");
        u5 = GameObject.Find("return0");
        u6 = GameObject.Find("square");

        GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, 0.5f);
        u6.GetComponent<SpriteRenderer>().color = new Vector4(1f, 0.8f, 0.4f, 1f);
        u1.GetComponent<Image>().color = new Vector4(1f, 1f, 1f, 0f);
        u2.GetComponent<Image>().color = new Vector4(1f, 1f, 1f, 0f);
        u3.GetComponent<Image>().color = new Vector4(1f, 1f, 1f, 0f);
        u4.GetComponent<Image>().color = new Vector4(1f, 1f, 1f, 0f);
        u5.GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, 0f);

        starttime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >starttime && Time.time < starttime + 2f)
        {
            transparent += 1.5f * Time.deltaTime;
            transparentplayer -= 1f * Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, transparentplayer);
            u6.GetComponent<SpriteRenderer>().color = new Vector4(1f, 0.8f, 0.4f, transparentplayer);
            u1.GetComponent<Image>().color = new Vector4(1f, 1f, 1f, transparent);
            u2.GetComponent<Image>().color = new Vector4(1f, 1f, 1f, transparent);
            u3.GetComponent<Image>().color = new Vector4(1f, 1f, 1f, transparent);
            u4.GetComponent<Image>().color = new Vector4(1f, 1f, 1f, transparent);
            u5.GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, transparent);

        }
    }
}
