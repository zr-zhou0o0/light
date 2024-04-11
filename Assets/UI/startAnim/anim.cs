using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class anim : MonoBehaviour
{
    public float enterTime = 0;
    public float transparent = 1;
    public GameObject bg;
    public GameObject curtain1;
    // Start is called before the first frame update
    void Start()
    {
        enterTime = Time.time;
        bg = GameObject.Find("7");
        curtain1 = GameObject.Find("curtain1");
        curtain1.GetComponent<Image>().enabled = true;
        curtain1.GetComponent<Image>().color = new Vector4(1f, 1f, 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > enterTime + 3f && Time.time < enterTime + 4f)//防止后面没办法再把transparent变成1
        {
            transparent -= 1f * Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Vector4(255, 255, 255f, transparent);
            bg.GetComponent<SpriteRenderer>().color = new Vector4(255, 255, 255f, transparent);
            curtain1.GetComponent<Image>().color = new Vector4(1f, 1f, 1f, transparent);
        }

        if(Time.time > enterTime + 4f && Time.time < enterTime + 4.2f)//防止后面没办法把它再变成true
        {
            curtain1.GetComponent<Image>().enabled = false;
        }
    }
}
