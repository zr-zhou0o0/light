using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flower1 : MonoBehaviour
{
    public int flower1atv = 0;
    public int flower1move = 0;
    public float transparent = 0;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (flower1atv == 1)
        {
            if (transparent <= 1)
            {
                transparent += 1f * Time.deltaTime;
            }
            GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, transparent);
        }

        if (flower1atv == 1 && flower1move == 1 )
        {
            transform.Rotate(new Vector3(0, 0, 1f), 0.5f);

        }

    }

    private void OnMouseDown()
    {
        if(flower1atv == 1)
        {
            flower1move = 1;
            GameObject.Find("wf1").GetComponent<wf1>().wf1move = 1;
        }
    }


}
