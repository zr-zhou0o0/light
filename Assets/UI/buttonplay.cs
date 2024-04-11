using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonplay : MonoBehaviour
{
    AsyncOperation operation;
    public float clicktime = -10;//
    public int skipped = 0;//

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.Log(operation.progress);
      if(Time.time > clicktime + 2f && Time.time < clicktime + 2.5f && skipped == 0 )//
        {
            Debug.Log("skip");
            StartCoroutine(loadScene());
            skipped = 1;

        }
    }

    public void clickButton()
    {
        Debug.Log("click");
        clicktime = Time.time;//
        GameObject.Find("loading").GetComponent<loading>().loadingatv = 2;//
        GetComponent<AudioSource>().Play();


    }

    IEnumerator loadScene()
    {
        operation = SceneManager.LoadSceneAsync(1);
        yield return operation;
    }

}
