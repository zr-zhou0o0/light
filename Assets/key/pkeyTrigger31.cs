using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkeyTrigger31 : MonoBehaviour
{
    public int pkeyTrigger31Active;
    //public int lock31;
    // Start is called before the first frame update
    void Start()
    {
        pkeyTrigger31Active = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)//±ðÍüÁË2d£¡£¡
    {

        pkeyTrigger31Active = 1;
        GetComponent<AudioSource>().Play();
        Debug.Log("pkeytrigger31 is 1");
    }
}
