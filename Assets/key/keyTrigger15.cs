using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger15 : MonoBehaviour
{
    public GameObject enterTrigger;
    public int entered = 0;
    public float bgm5StartTime1 = 0;//第一次播放的开始时间
    public float bgm5StartTime = 0;
    public float bgm5DeltaTime = 30f;
    public int replay = 0;

    public int keynote1 = 0;
    public int keynote2 = 0;

    public int lock5 = 0;

    //从starttime1开始，每过30s，bgmstarttime重置，bgm播放重置
    //（检查一下能不能成功重置音乐）
    //key1和key2都变成0
    //在15-16s之中弹一下，key1=1，17-18s弹一下，key2=1
    //如果key1和key2都是1，那么就解锁灯

    // Start is called before the first frame update
    void Start()
    {
        enterTrigger = GameObject.Find("enterTrigger5");
    }

    // Update is called once per frame
    void Update()
    {
        bgm5StartTime1 = enterTrigger.GetComponent<room5Enter>().bgm5StartTime;
        entered = enterTrigger.GetComponent<room5Enter>().entered;

        if(entered == 1 && (Time.time-bgm5StartTime1)%bgm5DeltaTime < 1f && replay == 0)
        {
            enterTrigger.GetComponent<AudioSource>().Stop();
            enterTrigger.GetComponent<AudioSource>().Play();
            bgm5StartTime = Time.time;
            keynote1 = 0;
            keynote2 = 0;

            replay = 1;
        }

        if(entered == 1 && (Time.time - bgm5StartTime1)%bgm5DeltaTime > bgm5DeltaTime - 5f && replay == 1)
        {
            replay = 0;
        }

        if(keynote1 == 1 && keynote2 == 1)
        {
            Debug.Log("unlock!!");
            lock5 = 1;
        }

        //Debug.Log(Time.time);//

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        if(Time.time > bgm5StartTime + 15f && Time.time < bgm5StartTime + 17f)
        {
            keynote1 = 1;
        }

        if (Time.time > bgm5StartTime + 17f && Time.time < bgm5StartTime + 19f)
        {
            keynote2 = 1;
        }

    }


}
