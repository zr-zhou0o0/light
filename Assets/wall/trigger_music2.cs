using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class trigger_music2 : MonoBehaviour
{
    GameObject musicOn;//find不能写在这里
    GameObject musicOff;
    public int musicChange = 0;

    // Start is called before the first frame update
    void Start()
    {
        musicOn = GameObject.Find("bgmroom2");
        musicOff = GameObject.Find("backgroundmusic");
    }

    // Update is called once per frame
    void Update()
    {
        if(musicChange == 1)
        {
            musicOn.GetComponent<AudioSource>().volume += 0.1f * Time.deltaTime;
            musicOff.GetComponent<AudioSource>().volume -= 0.1f * Time.deltaTime;
        }
       
        //补充写一个bgm2 change stop的判断
        //注意：改这里也要改room3enter的bgm2

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        musicOn.GetComponent<AudioSource>().Play();
        musicChange = 1;
        Debug.Log("bgm2play!");
    }

}
