using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkeyTrigger28 : MonoBehaviour
{
    public int pkeyTrigger28Active;
    //public int lock31;
    // Start is called before the first frame update
    void Start()
    {
        pkeyTrigger28Active = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)//±ðÍüÁË2d£¡£¡
    {

        pkeyTrigger28Active = 1;
        GetComponent<AudioSource>().Play();
        Debug.Log("pkeytrigger28is 1");
    }
}
