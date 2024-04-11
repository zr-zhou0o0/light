using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger15 : MonoBehaviour
{
    public GameObject enterTrigger;
    public int entered = 0;
    public float bgm5StartTime1 = 0;//��һ�β��ŵĿ�ʼʱ��
    public float bgm5StartTime = 0;
    public float bgm5DeltaTime = 30f;
    public int replay = 0;

    public int keynote1 = 0;
    public int keynote2 = 0;

    public int lock5 = 0;

    //��starttime1��ʼ��ÿ��30s��bgmstarttime���ã�bgm��������
    //�����һ���ܲ��ܳɹ��������֣�
    //key1��key2�����0
    //��15-16s֮�е�һ�£�key1=1��17-18s��һ�£�key2=1
    //���key1��key2����1����ô�ͽ�����

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
