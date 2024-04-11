using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkeyTrigger21 : MonoBehaviour
{
    public int pkeyTrigger21Active;
    //public int lock31;
    // Start is called before the first frame update
    void Start()
    {
        pkeyTrigger21Active = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)//±ðÍüÁË2d£¡£¡
    {

        pkeyTrigger21Active = 1;
        GetComponent<AudioSource>().Play();
        Debug.Log("pkeytrigger21 is 1");
    }
}
