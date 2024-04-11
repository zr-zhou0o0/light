using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger20 : MonoBehaviour
{
    public GameObject key20l;

    // Start is called before the first frame update
    void Start()
    {
        key20l = GameObject.Find("key20l");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        key20l.GetComponent<SpriteRenderer>().enabled = true;

    }



}
