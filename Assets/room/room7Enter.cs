using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room7Enter : MonoBehaviour
{

    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;

    // Start is called before the first frame update
    void Start()
    {
        wall1 = GameObject.Find("wall31l");
        wall2 = GameObject.Find("wall30l");
        wall3 = GameObject.Find("wall8l");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        wall1.GetComponent<SpriteRenderer>().enabled = true;
        wall2.GetComponent<SpriteRenderer>().enabled = true;
        wall3.GetComponent<SpriteRenderer>().enabled = true;
    }


}
