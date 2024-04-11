using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkeyTrigger29 : MonoBehaviour
{
    public int pkeyTrigger29Active;
    //public int lock31;
    // Start is called before the first frame update
    void Start()
    {
        pkeyTrigger29Active = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)//±ðÍüÁË2d£¡£¡
    {

        pkeyTrigger29Active = 1;
        GetComponent<AudioSource>().Play();
        Debug.Log("pkeytrigger29is 1");
    }
}
