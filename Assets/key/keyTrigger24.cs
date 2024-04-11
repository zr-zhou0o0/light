using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger24 : MonoBehaviour
{
    public GameObject key24l;

    // Start is called before the first frame update
    void Start()
    {
        key24l = GameObject.Find("key24l");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        key24l.GetComponent<SpriteRenderer>().enabled = true;

    }



}
