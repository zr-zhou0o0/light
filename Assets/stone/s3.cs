using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s3 : MonoBehaviour
{
    public int stateChange = 0;

    public int lightening = 0;
    public int darkening = 0;

    public float startTime = -10f;
    public float endTime = -10f;

    public int stoneState = 0;//0代表暗1代表亮

    public float r = 0.37f;
    public float g = 0.34f;
    public float b = 0.365f;

    public lock1 lock1;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Vector4(0.37f, 0.34f, 0.365f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if(stateChange == 1)
        {
            if(stoneState == 0)
            {
                lightening = 1;
                darkening = 0;
                stoneState = 1;
                startTime = Time.time;
                endTime = Time.time + 1f;
            }
            else if(stoneState == 1)
            {
                lightening = 0;
                darkening = 1;
                stoneState = 0;
                startTime = Time.time;
                endTime = Time.time + 1f;
            }
            stateChange = 0;
        }


        if(lightening == 1 && Time.time > startTime && Time.time < endTime)
        {
            if (r < 1) r += 0.3f * Time.deltaTime;
            if (g < 1) g += 0.3f * Time.deltaTime;
            if (b < 1) b += 0.3f * Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Vector4(r, g, b, 1f);
        }

        if(darkening == 1 && Time.time > startTime && Time.time < endTime)
        {
            if (r > 0.37f) r -= 0.3f * Time.deltaTime;
            if (g > 0.34f) g -= 0.3f * Time.deltaTime;
            if (b > 0.365f) b -= 0.3f * Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Vector4(r, g, b, 1f);
        }

        if((lightening == 1 || darkening == 1) && Time.time > endTime)
        {
            lightening = 0;
            darkening = 0;
            startTime = -10f;
            endTime = -10f;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(stoneState == 0)
        {
            GetComponent<AudioSource>().Play();
            lock1.arr[2] = lock1.arr[1];
            lock1.arr[1] = lock1.arr[0];
            lock1.arr[0] = 3;
        }
        else if(stoneState == 1)
        {
            GameObject.Find("s3l").GetComponent<AudioSource>().Play();
            lock1.arr[2] = lock1.arr[1];
            lock1.arr[1] = lock1.arr[0];
            lock1.arr[0] = 0;
        }
    }
}
