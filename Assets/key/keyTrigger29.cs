using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger29 : MonoBehaviour
{
    public GameObject key29l;
    public GameObject key30l;
    public GameObject key31l;
    public GameObject key34l;

    // Start is called before the first frame update
    void Start()
    {
        key29l = GameObject.Find("key29l");
        key30l = GameObject.Find("key30l");
        key31l = GameObject.Find("key31l");
        key34l = GameObject.Find("key34l");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        key29l.GetComponent<SpriteRenderer>().enabled = true;
        key30l.GetComponent<SpriteRenderer>().enabled = true;
        key31l.GetComponent<SpriteRenderer>().enabled = true;
        key34l.GetComponent<SpriteRenderer>().enabled = true;

    }



}
