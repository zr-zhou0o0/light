using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkeyTrigger15 : MonoBehaviour
{

    public int pkeyTrigger15Active = 0;
    public GameObject lightcontroller;

    // Start is called before the first frame update
    void Start()
    {
        lightcontroller = GameObject.Find("plight12d");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        lightcontroller.GetComponent<plight12controller>().keyorder[3] = lightcontroller.GetComponent<plight12controller>().keyorder[2]; //��keyorder�����������
        lightcontroller.GetComponent<plight12controller>().keyorder[2] = lightcontroller.GetComponent<plight12controller>().keyorder[1];
        lightcontroller.GetComponent<plight12controller>().keyorder[1] = lightcontroller.GetComponent<plight12controller>().keyorder[0];
        lightcontroller.GetComponent<plight12controller>().keyorder[0] = 15;    //�ѵ�һ��keynumber�������޸ĳ��ټ����

        GetComponent<AudioSource>().Play();  //�ټ���Ӧ����������
    }
}
