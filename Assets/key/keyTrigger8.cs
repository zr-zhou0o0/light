using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger8 : MonoBehaviour
{
    public int keyTri8Active = 0;
    public GameObject keyTriPrev1;//public
    public int keyTriPrev1Active = 0;
    // GameObject keyTriPrev2;
    // int keyTriPrev2Active = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)//triggerһ��ʼд����collision������
    {
        keyTriPrev1 = GameObject.Find("keyTrigger9");//����д��start���Ϊÿ�ζ�Ҫ����find
        keyTriPrev1Active = keyTriPrev1.GetComponent<keyTrigger9>().keyTri9Active;
        GetComponent<AudioSource>().Play();
        if (keyTriPrev1Active == 1)
        {
            if (keyTri8Active == 0) keyTri8Active = 1;
            else
            {
                keyTri8Active = 0;
                keyTriPrev1.GetComponent<keyTrigger9>().keyTri9Active = 0; //ok

            }
        }
    }

}
