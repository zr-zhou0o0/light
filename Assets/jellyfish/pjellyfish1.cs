using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pjellyfish1 : MonoBehaviour
{
    public float speed;
    //private float MoveSpeed = 0.5f;
    public GameObject SetActiveObject1;
    public float length;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        SetActiveObject1 = GameObject.Find("pjellyfish1");
        length = SetActiveObject1.GetComponent<pjellyfish1>().transform.position.x;
        height = SetActiveObject1.GetComponent<pjellyfish1>().transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
