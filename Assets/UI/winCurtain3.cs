using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winCurtain3 : MonoBehaviour
{
    public float startTime = -10f;
    public float transparent = 1;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > startTime + 2f && Time.time <startTime + 6f)
        {
            transparent -= 0.15f * Time.deltaTime;
            GetComponent<Image>().color = new Vector4(0f, 0f, 0f, transparent);
        }
        if(Time.time > startTime + 6f)
        {
            GetComponent<Image>().enabled = false;
        }
    }
}
