using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class room5Enter : MonoBehaviour
{

    public GameObject musicOff1;
    public GameObject musicOff2;
    public int musicChange = 0;
    public float bgm5StartTime = 0f;
    public int entered = 0;

    // Start is called before the first frame update
    void Start()
    {

        musicOff1 = GameObject.Find("enterTrigger3");
        musicOff2 = GameObject.Find("backgroundmusic");
    }

    // Update is called once per frame
    void Update()
    {
        if (musicChange == 1)
        {
            // Debug.Log("musicchange!musicoff1 volume is:");//
            //Debug.Log(musicOff1.GetComponent<AudioSource>().volume);//
            GetComponent<AudioSource>().volume += 0.1f * Time.deltaTime;
            musicOff1.GetComponent<AudioSource>().volume -= 0.2f * Time.deltaTime;//因为bgm2的musictrigger没关，所以两个0.1抵消了
            musicOff2.GetComponent<AudioSource>().volume -= 0.2f * Time.deltaTime;

        }
        /*
        if(musicOff.GetComponent<AudioSource>().volume == 0)
        {
            musicOff.GetComponent<AudioSource>().Stop();
        }
        */
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        musicChange = 1;
        Debug.Log("bgm5play!");
        bgm5StartTime = Time.time;
        entered = 1;
    }

}
