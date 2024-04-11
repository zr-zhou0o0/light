using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twallTrigger1 : MonoBehaviour
{
      public int twall1Active =0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter2D(Collider2D collision)
    {
      twall1Active =1;
    }
}
    

