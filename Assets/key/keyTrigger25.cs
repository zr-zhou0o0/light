using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger25 : MonoBehaviour
{
    public GameObject key25l;

    // Start is called before the first frame update
    void Start()
    {
        key25l = GameObject.Find("key25l");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        key25l.GetComponent<SpriteRenderer>().enabled = true;

    }



}
