using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class playercontroller : MonoBehaviour
{

   // Vector3 flippedScale = new Vector3(-0.5f, 0.5f, 0.5f); //���ﶯ����ת

    private Rigidbody2D rigi;
    private Animator animator;
    private float moveX; //ˮƽ����ֵ
    private int moveChangeAni;
    public float jumpRate = 1000000f;//time�ĵ�λ������һ���֮һ�롣��
    private float nextJump = 0.0f;
    

    float moveSpeed = 1f;
    float jumpForce = 9f;//�����������1��������1��������������10���������

    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Jump();
        
    }

    private void Movement()
    {
        moveX = Input.GetAxis("Horizontal");
        
        rigi.velocity = new Vector2(moveSpeed * moveX * 3, rigi.velocity.y);

        if (moveX > 0) moveChangeAni = 1;
        else if (moveX < 0) moveChangeAni = -1;
        else moveChangeAni = 0;
        animator.SetInteger("movement", moveChangeAni);
        
    }

    /*
    private void Direction()
    {
        if (moveX > 0) transform.localScale = flippedScale;
        else if (moveX < 0) transform.localScale = new Vector3(0.5f,0.5f,0.5f);
    }
    */

    private void Jump()
    {
        if(Input.GetKey(KeyCode.Space) && Time.time > nextJump)
        {
            Debug.Log("get space and jump");
          //  Debug.Log( Time.time);
            nextJump = Time.time + jumpRate;
           // Debug.Log(nextJump);
            rigi.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }


}
