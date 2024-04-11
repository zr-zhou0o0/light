using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkeyTrigger13 : MonoBehaviour
{

    public int pkeyTrigger13Active = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)//±ðÍüÁË2d£¡£¡
    {

        pkeyTrigger13Active = 1;
        GetComponent<AudioSource>().Play();
        Debug.Log("pkeytrigger13 is 1");
    }
}
