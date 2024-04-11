using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTrigger10 : MonoBehaviour
{
    public int keyTri10Active = 0;
    GameObject keyTriPrev1;
    int keyTriPrev1Active = 0;
    GameObject keyTriPrev2;
    int keyTriPrev2Active = 0;
    public int lock3 = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        keyTriPrev1 = GameObject.Find("keyTrigger8");//必须是这个位置
        keyTriPrev2 = GameObject.Find("keyTrigger9");
        keyTriPrev1Active = keyTriPrev1.GetComponent<keyTrigger8>().keyTri8Active;
        keyTriPrev2Active = keyTriPrev2.GetComponent<keyTrigger9>().keyTri9Active;

        GetComponent<AudioSource>().Play();
        if (keyTriPrev1Active == 1)
        {
            keyTri10Active = 1;
            lock3 = 1;
        }
        else
        {
            GameObject.Find("keyTrigger9").GetComponent<keyTrigger9>().keyTri9Active = 0;
            GameObject.Find("keyTrigger8").GetComponent<keyTrigger8>().keyTri8Active = 0;

        }
    }

}
