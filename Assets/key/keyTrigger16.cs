using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger16 : MonoBehaviour
{
    public GameObject key16l;

    // Start is called before the first frame update
    void Start()
    {
        key16l = GameObject.Find("key16l");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        key16l.GetComponent<SpriteRenderer>().enabled = true;

    }



}
