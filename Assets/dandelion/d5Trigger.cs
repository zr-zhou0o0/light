using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d5Trigger : MonoBehaviour
{
    public int d5Triatv = 0;

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
        if (d5Triatv == 1)
        {

            GameObject.Find("s5").GetComponent<s5>().stateChange = 1;
        }
    }

}
