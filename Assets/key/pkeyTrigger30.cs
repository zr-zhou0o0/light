using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkeyTrigger30 : MonoBehaviour
{
    public int pkeyTrigger30Active;
    //public int lock31;
    // Start is called before the first frame update
    void Start()
    {
        pkeyTrigger30Active = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)//±ðÍüÁË2d£¡£¡
    {

        pkeyTrigger30Active = 1;
        GetComponent<AudioSource>().Play();
        Debug.Log("pkeytrigger30 is 1");
    }
}
