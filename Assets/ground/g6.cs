using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g6 : MonoBehaviour
{
    public int g6atv = 0;//atv是active的意思
    public float transparent = 0;
    public t1d myt1d;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Vector4(255, 255f, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(g6atv == 1)
        {
            transparent += 1f * Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Vector4(255, 255f, 255, transparent);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collide!");
        g6atv = 1;
        myt1d.t1datv = 1;
    }

}
