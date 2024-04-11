using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaf3 : MonoBehaviour
{
    public int leaf3atv = 0;//atv是active的意思
    public float transparent = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Vector4(255, 255f, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(leaf3atv == 1)
        {
            transparent += 1f * Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Vector4(255, 255f, 255, transparent);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collide!");
        leaf3atv = 1;
    }
  

}
