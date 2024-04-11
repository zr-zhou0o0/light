using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plight13controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject setActiveObject;
    public pwall19d anything1;
    public pkeyTrigger32 anything2;
    void Start()
    {
        setActiveObject = GameObject.Find("plight13l");
    }

    // Update is called once per frame
    void Update()
    {
        if (anything2.pkeyTrigger32Active == 1)
        {
            anything1.pwall19Active = 1;
            setActiveObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
