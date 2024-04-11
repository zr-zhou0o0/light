using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkey22d : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pkey22lMode;
    public pkeyTrigger32 anything1;
    public pkeyTrigger22 anything2;
    public int derection1;
    public int derection2;
    public int pkeyRelativeThing1;
    public int pkeyRelativeThing2;
    public GameObject SetActiveObject1;
    public double height;
    public int pkeyTrigger22Active;

    void Start()
    {
        derection1 = 0;
        derection2 = 0;
        pkeyRelativeThing1 = 0;
        pkeyRelativeThing2 = 0;
        SetActiveObject1 = GameObject.Find("pkey22d");
        pkey22lMode = GameObject.Find("pkey22l");
       //把height在这里初始化了，导致height仅代表一个初始位置的值
        pkeyTrigger22Active = 0;
    }

    // Update is called once per frame
    void Update()
    {
        height = SetActiveObject1.GetComponent<pkey22d>().transform.position.y;//height的初始化要逐帧进行，确保height能一直进行更新！！
        if ((anything1.pkeyTrigger32Active == 1) && (pkeyRelativeThing1 == 0)&&(height>(-32.75)))
        {
            SetActiveObject1.transform.Translate(new Vector3(0, -2, 0) * 0.001f);
        }
        if (height <= (-32.75))
        {
            pkeyRelativeThing1 = 1;
        }
        if ((anything2.pkeyTrigger22Active == 1) && (pkeyRelativeThing2 == 0) && (height <(-28.45)))
        {
            SetActiveObject1.transform.Translate(new Vector3(0, 3, 0) * 0.001f);
            Debug.Log("pkeytrigger22 is 1");
            pkey22lMode.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (height >= (-28.45))
        {
            pkeyRelativeThing2 = 1;
        }
    }
   /* public void OnCollisionEnter2D(Collision2D collision)
    {
        pkeyTrigger22Active = 1;
        GetComponent<AudioSource>().Play();
        Debug.Log("pkeytrigger22 is 1");
        pkey22lMode.GetComponent<SpriteRenderer>().enabled = true;
    }*/
}
