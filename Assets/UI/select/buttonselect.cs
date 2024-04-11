using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonselect : MonoBehaviour
{
    public buttondream d;
    public buttonforest f;
    public buttonsky s;
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
        if (Time.time > clicktime + 2f && Time.time < clicktime + 2.5f && skipped == 0)//
        {
            Debug.Log("skip");
            if (d.select == 1)
            {
                StartCoroutine(loadScened());
            }
            else if (f.select == 1)
            {
                StartCoroutine(loadScenef());
            }
            else
            {
                StartCoroutine(loadScenes());
            }
            skipped = 1;

        }
    }

    public void clickButton()
    {
        
        Debug.Log("click");
        clicktime = Time.time;//
        GameObject.Find("exiting").GetComponent<exitingPortal>().exitingatv = 1;


    }
    IEnumerator loadScenes()
    {
        operation = SceneManager.LoadSceneAsync(6);
        yield return operation;
    }
    IEnumerator loadScenef()
    {
        operation = SceneManager.LoadSceneAsync(4);
        yield return operation;
    }
    IEnumerator loadScened()
    {
        operation = SceneManager.LoadSceneAsync(3);
        yield return operation;
    }
}
