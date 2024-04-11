using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altarla5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("curtain").GetComponent<curtains2>().win = 1;
    }
}
