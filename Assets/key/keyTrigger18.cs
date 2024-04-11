using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger18 : MonoBehaviour
{
    public GameObject key18l;
    public GameObject key19l;

    // Start is called before the first frame update
    void Start()
    {
        key18l = GameObject.Find("key18l");
        key19l = GameObject.Find("key19l");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        key18l.GetComponent<SpriteRenderer>().enabled = true;
        key19l.GetComponent<SpriteRenderer>().enabled = true;

    }



}
