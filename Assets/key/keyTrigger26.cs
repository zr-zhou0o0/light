using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger26 : MonoBehaviour
{
    public GameObject key26l;
    public GameObject key27l;
    public GameObject key28l;
    public GameObject key36l;

    // Start is called before the first frame update
    void Start()
    {
        key26l = GameObject.Find("key26l");
        key27l = GameObject.Find("key27l");
        key28l = GameObject.Find("key28l");
        key36l = GameObject.Find("key36l");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        key26l.GetComponent<SpriteRenderer>().enabled = true;
        key27l.GetComponent<SpriteRenderer>().enabled = true;
        key28l.GetComponent<SpriteRenderer>().enabled = true;
        key36l.GetComponent<SpriteRenderer>().enabled = true;

    }



}
