using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger2 : MonoBehaviour
{

    public int keyTrigger2Active = 0;

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

        keyTrigger2Active = 1;
        GetComponent<AudioSource>().Play();
        Debug.Log("keytrigger2 is 1");
    }
}
