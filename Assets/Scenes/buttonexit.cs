using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonexit : MonoBehaviour
{
    public float clicktime = -10;
    public int skipped = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > clicktime + 2f && Time.time < clicktime + 2.5f && skipped == 0)
        {
            Debug.Log("skip");
            Application.Quit();
            skipped = 1;

        }
    }

    public void quitGame()
    {
        Debug.Log("quit");
        clicktime = Time.time;
        GameObject.Find("loading").GetComponent<loading>().loadingatv = 3;

    }

}
