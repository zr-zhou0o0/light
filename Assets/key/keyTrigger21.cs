using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger21 : MonoBehaviour
{
    public GameObject key21l;

    // Start is called before the first frame update
    void Start()
    {
        key21l = GameObject.Find("key21l");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        key21l.GetComponent<SpriteRenderer>().enabled = true;

    }



}
