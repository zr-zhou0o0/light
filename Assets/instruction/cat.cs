using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    public GameObject dialogue1;
    public GameObject dialogue2;
    public GameObject dialogue3;

    public int dia1on = 1;
    public int dia2on = 0;
    public int dia3on = 0;


    // Start is called before the first frame update
    void Start()
    {
        dialogue1 = GameObject.Find("dialogue1");
        dialogue2 = GameObject.Find("dialogue2");
        dialogue3 = GameObject.Find("dialogue3");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        
      //为了防止点一下全消失了，必须写成if-else而不是ififif。。。

        if (dia3on == 1)
        {
            dialogue3.GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            dia3on = 0;

        }

        else if (dia2on == 1)
        {
            dialogue2.GetComponent<SpriteRenderer>().enabled = false;
            dialogue3.GetComponent<SpriteRenderer>().enabled = true;
            dia2on = 0;
            dia3on = 1;
        }


        else if (dia1on == 1)
        {
            dialogue1.GetComponent<SpriteRenderer>().enabled = false;
            dialogue2.GetComponent<SpriteRenderer>().enabled = true;
            dia1on = 0;
            dia2on = 1;
        }


    }


}
