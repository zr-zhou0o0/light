using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class keyTrigger5 : MonoBehaviour
{
    public int keyTrigger5Active = 0;
    public GameObject keyTriNext;
    public int keyTriNextActive = 0;

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
        keyTriNext = GameObject.Find("keytrigger7");
        keyTriNextActive = keyTriNext.GetComponent<keyTrigger7>().keyTri7Active;
        if(keyTriNextActive == 1)
        {
            keyTriNext.GetComponent<keyTrigger7>().keyTri7Active = 0;//???这样写是否能够真的改变keytri7active？
            //GameObject.Find("keytrigger7").GetComponent<keyTrigger7>().keyTri7Active = 0;
        }
        keyTrigger5Active = 1;
        GetComponent<AudioSource>().Play();

    }

}
