using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkeyTrigger23 : MonoBehaviour
{
    public int pkeyTrigger23Active;
    //public int lock31;
    // Start is called before the first frame update
    void Start()
    {
        pkeyTrigger23Active = 0;

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)//±ðÍüÁË2d£¡£¡
    {

        pkeyTrigger23Active = 1;
        GetComponent<AudioSource>().Play();
        Debug.Log("pkeytrigger23 is 1");
    }
}
