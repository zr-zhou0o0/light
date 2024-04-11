using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flower2 : MonoBehaviour
{
    public int flower2atv = 0;
    public int flower2move = 0;
    public float transparent = 0;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (flower2atv == 1)
        {
            if (transparent <= 1)
            {
                transparent += 1f * Time.deltaTime;
            }
            GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, transparent);
        }

        if (flower2atv == 1 && flower2move == 1)
        {
            transform.Rotate(new Vector3(0, 0, 1f), 0.5f);

        }

    }

    private void OnMouseDown()
    {
        if (flower2atv == 1)
        {
            flower2move = 1;
            GameObject.Find("wf2").GetComponent<wf2>().wf2move = 1;
            GameObject.Find("wf3").GetComponent<wf3>().wf3move = 1;
        }
    }

}
