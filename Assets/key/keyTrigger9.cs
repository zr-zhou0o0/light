using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class keyTrigger9 : MonoBehaviour
{
    public int keyTri9Active = 0;
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
        keyTriNext = GameObject.Find("keyTrigger8");
        keyTriNextActive = keyTriNext.GetComponent<keyTrigger8>().keyTri8Active;
        if (keyTriNextActive == 1)
        {
            keyTriNext.GetComponent<keyTrigger8>().keyTri8Active = 0;//???这样写是否能够真的改变keytri7active？
            //GameObject.Find("keytrigger7").GetComponent<keyTrigger7>().keyTri7Active = 0;
        }
        keyTri9Active = 1;
        GetComponent<AudioSource>().Play();

    }

}
