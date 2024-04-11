using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaf4 : MonoBehaviour
{
    public int leaf4atv = 0;//atv是active的意思
    public float transparent = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Vector4(255, 255f, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(leaf4atv == 1)
        {
            transparent += 1f * Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Vector4(255, 255f, 255, transparent);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collide!");
        leaf4atv = 1;
    }
  

}
