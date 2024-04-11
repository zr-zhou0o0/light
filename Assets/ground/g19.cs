using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g19 : MonoBehaviour
{
    public int g19atv = 0;//atv是active的意思
    public float transparent = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Vector4(255, 255f, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (g19atv == 1)
        {
            transparent += 1f * Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Vector4(255, 255f, 255, transparent);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collide!");
        g19atv = 1;

    }

}
