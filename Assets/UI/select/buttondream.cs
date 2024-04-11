using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttondream : MonoBehaviour
{
    public int select = 0;
    public buttondream d;
    public buttonforest f;
    public buttonsky s;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickButton()
    {
        Debug.Log("bdream=1");
        select = 1;
        s.select = 0;
        f.select = 0;
    }


}
