using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d5 : MonoBehaviour
{
    public int d5atv = 0;
    public float transparent = 0;
    private Animator animator;//创建了一个组件的类

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, 0f);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (d5atv == 1)
        {
            transparent += 1f * Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, transparent);
            animator.Play("dandelionGrow");
        }


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        d5atv = 1;
        GameObject.Find("d5Trigger").GetComponent<d5Trigger>().d5Triatv = 1;
    }


}
