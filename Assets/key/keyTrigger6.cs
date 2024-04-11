using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger6 : MonoBehaviour
{
    public int keyTri6Active = 0;
    GameObject keyTriPrev1;
    int keyTriPrev1Active = 0;
     GameObject keyTriPrev2;
     int keyTriPrev2Active = 0;
    public int lock2 = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        keyTriPrev1 = GameObject.Find("keytrigger7");//必须是这个位置
        keyTriPrev2 = GameObject.Find("keytrigger5");
        keyTriPrev1Active = keyTriPrev1.GetComponent<keyTrigger7>().keyTri7Active;
        keyTriPrev2Active = keyTriPrev2.GetComponent<keyTrigger5>().keyTrigger5Active;

        GetComponent<AudioSource>().Play();
        if (keyTriPrev1Active == 1)
        {
            keyTri6Active = 1;
            lock2 = 1;
        }
        else
        {
            GameObject.Find("keytrigger5").GetComponent<keyTrigger5>().keyTrigger5Active = 0;
            GameObject.Find("keytrigger7").GetComponent<keyTrigger7>().keyTri7Active = 0;

        }
    }
    
}
