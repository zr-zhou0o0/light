using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger1 : MonoBehaviour
{

    public int keyTrigger1Active = 0;

    public GameObject keyTriggerPrev;//��һ��������
    public int keyTriggerPrevActive = 0;//��һ����������ֵ

    public int lock1 = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)//һ��ʼûд2d���ò���
    {

        keyTrigger1Active = 1;
        GetComponent<AudioSource>().Play();
        Debug.Log("keytrigger1 is 1");

        keyTriggerPrev = GameObject.Find("keyTrigger2");//��һ��������
        if(keyTriggerPrev != null)  Debug.Log("findit!");

        keyTriggerPrevActive = keyTriggerPrev.GetComponent<keyTrigger2>().keyTrigger2Active;

        if(keyTriggerPrevActive == 1)//�жϵ�����==����=����
        {
            lock1 = 1;
            Debug.Log("lock1 is 1");
        }
       
    }
}
