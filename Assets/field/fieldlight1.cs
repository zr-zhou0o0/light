using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fieldlight1 : MonoBehaviour
{
    public int fieldlightActive = 0;
    public GameObject player;
    public GameObject forcePivot;
    public float jumpForce = 13f;


    public float MaxScale = 3.06f;
    public float scale = 0f;
    public float deltaScale = 1f;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("role0");
        forcePivot = GameObject.Find("forcePivot");
    }

    // Update is called once per frame
    void Update()
    {
        if (fieldlightActive == 1 && scale < MaxScale)
        {
            scale += deltaScale * Time.deltaTime;
            transform.localScale = new Vector3(1.649f, scale, 2.8571f);
        }

        if(fieldlightActive == 1 && forcePivot.transform.position.y > -9.00 && forcePivot.transform.position.y < -0.8)
        {
            if(forcePivot.transform.position.x < -27.02 && forcePivot.transform .position.x > -28.68)
            {
                player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Force);
            }
        }


    }
}
