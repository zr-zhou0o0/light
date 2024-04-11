using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d1 : MonoBehaviour
{
    public int d1atv = 0;
    public float transparent = 0;
    private Animator animator;//������һ���������

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, 0f);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(d1atv == 1)
        {
            transparent += 1f * Time.deltaTime;
            GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, transparent);
            animator.Play("dandelionGrow");
        }


    }
}
