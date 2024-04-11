using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger22 : MonoBehaviour
{
    public GameObject key22l;

    // Start is called before the first frame update
    void Start()
    {
        key22l = GameObject.Find("key22l");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        key22l.GetComponent<SpriteRenderer>().enabled = true;

    }



}
