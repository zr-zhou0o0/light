using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger17 : MonoBehaviour
{
    public GameObject key17l;

    // Start is called before the first frame update
    void Start()
    {
        key17l = GameObject.Find("key17l");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        key17l.GetComponent<SpriteRenderer>().enabled = true;

    }



}
