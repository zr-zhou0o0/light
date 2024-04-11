using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room8Enter : MonoBehaviour
{

    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;

    public int lock8 = 0;

    // Start is called before the first frame update
    void Start()
    {
        wall1 = GameObject.Find("wall26l");
        wall2 = GameObject.Find("wall28l");
        wall3 = GameObject.Find("wall29l");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        wall1.GetComponent<SpriteRenderer>().enabled = true;
        wall2.GetComponent<SpriteRenderer>().enabled = true;
        wall3.GetComponent<SpriteRenderer>().enabled = true;

        lock8 = 1;
    }


}
