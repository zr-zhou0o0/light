using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger35 : MonoBehaviour
{
    public GameObject key35l;

    // Start is called before the first frame update
    void Start()
    {
        key35l = GameObject.Find("key35l");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        key35l.GetComponent<SpriteRenderer>().enabled = true;

    }



}
