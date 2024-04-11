using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m1 : MonoBehaviour
{
    public int m1atv = 0;//atv是active的意思
    public float transparent = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Vector4(0.39f, 0.385f, 0.45f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (m1atv == 1)
        {
            transparent += 1f * Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Vector4(0.39f, 0.385f, 0.45f, transparent);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collide!");
        m1atv = 1;

    }

}
