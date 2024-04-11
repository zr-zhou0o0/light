using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger7 : MonoBehaviour
{
    public int keyTri7Active = 0;
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

    private void OnTriggerEnter2D(Collider2D collision)//trigger一开始写成了collision。。。
    {
        keyTriPrev1 = GameObject.Find("keytrigger5");//不能写在start里，因为每次都要重新find
        keyTriPrev1Active = keyTriPrev1.GetComponent<keyTrigger5>().keyTrigger5Active;
        GetComponent<AudioSource>().Play();
        if (keyTriPrev1Active == 1)
        {
            if(keyTri7Active == 0)  keyTri7Active = 1;
            else
            {
                keyTri7Active = 0;
                keyTriPrev1.GetComponent<keyTrigger5>().keyTrigger5Active = 0; //???
            }
        }
    }
    
}
