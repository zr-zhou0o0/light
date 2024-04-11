using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d3Trigger : MonoBehaviour
{
    public int d3Triatv = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if (d3Triatv == 1)
        {
            GameObject.Find("s3").GetComponent<s3>().stateChange = 1;
        }
    }
  
}
