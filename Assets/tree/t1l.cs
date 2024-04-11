using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t1l : MonoBehaviour
{
    public int t1latv = 0;
    public float transparent = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Vector4(255, 255f, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (t1latv == 1)
        {
            transparent += 1f * Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Vector4(255, 255f, 255, transparent);
            GameObject.Find("h1").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("h2").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("h3").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("h4").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("h5").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("h6").GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
