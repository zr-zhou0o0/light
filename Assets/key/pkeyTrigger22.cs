using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkeyTrigger22 : MonoBehaviour
{
    public int pkeyTrigger22Active;
    //public int lock31;
    // Start is called before the first frame update
    void Start()
    {
        pkeyTrigger22Active = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)//±ðÍüÁË2d£¡£¡
    {

        pkeyTrigger22Active = 1;
        GetComponent<AudioSource>().Play();
        Debug.Log("pkeytrigger22is 1");
    }
}
