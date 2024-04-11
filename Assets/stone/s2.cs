using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s2 : MonoBehaviour
{
    public int s2atv = 0;//atv是active的意思
    public float transparent = 0;

    public s1 s1;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Vector4(255, 255f, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (s2atv == 1)
        {
            transparent += 1f * Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Vector4(255, 255f, 255, transparent);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collide!");
        s2atv = 1;

        GetComponent<AudioSource>().Play();

        s1.stoneNumber[2] = s1.stoneNumber[1];
        s1.stoneNumber[1] = s1.stoneNumber[0];
        s1.stoneNumber[0] = 2;


    }

}
