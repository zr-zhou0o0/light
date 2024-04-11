using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger23 : MonoBehaviour
{
    public GameObject key23l;

    // Start is called before the first frame update
    void Start()
    {
        key23l = GameObject.Find("key23l");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        key23l.GetComponent<SpriteRenderer>().enabled = true;

    }



}
