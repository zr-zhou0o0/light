using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class froom3Enter : MonoBehaviour
{
    public int musicChange = 0;
    public GameObject musicOff1;


    // Start is called before the first frame update
    void Start()
    {
        musicOff1 = GameObject.Find("bgm1");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (musicChange == 1 )
        {
            GetComponent<AudioSource>().volume += 0.1f * Time.deltaTime;
            musicOff1.GetComponent<AudioSource>().volume -= 0.1f * Time.deltaTime;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if( GetComponent<AudioSource>().volume == 0) GetComponent<AudioSource>().Play(); //∑¿÷π÷ÿ∏¥≤•∑≈ 
        musicChange = 1;
        Debug.Log("bgm6play!");
    }
}
