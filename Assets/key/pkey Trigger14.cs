using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkeyTrigger14: MonoBehaviour
{

    public int pkeyTrigger14Active = 0;

    public GameObject pkeyTriggerPrev;//��һ��������
    public int pkeyTriggerPrevActive = 0;//��һ����������ֵ

    public int plock14 = 0;

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

        pkeyTrigger14Active = 1;
        GetComponent<AudioSource>().Play();
        Debug.Log("pkeytrigger14 is 1");

        pkeyTriggerPrev = GameObject.Find("pkeyTrigger13");//��һ��������
        if (pkeyTriggerPrev != null) Debug.Log("findit!");

        pkeyTriggerPrevActive = pkeyTriggerPrev.GetComponent<pkeyTrigger13>().pkeyTrigger13Active;

        if (pkeyTriggerPrevActive == 1)//�жϵ�����==����=����
        {
            plock14= 1;
            Debug.Log("plock14 is 1");
        }

    }
}