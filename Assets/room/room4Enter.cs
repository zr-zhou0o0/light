using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room4Enter : MonoBehaviour
{
    public int triggerActive = 0;

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
        triggerActive = 1;
    }

}
