using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaf2 : MonoBehaviour
{
    public int leaf2atv = 0;//atv��active����˼
    public float transparent = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Vector4(255, 255f, 255, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(leaf2atv == 1)
        {
            transparent += 1f * Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Vector4(255, 255f, 255, transparent);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collide!");
        leaf2atv = 1;
    }
  

}
