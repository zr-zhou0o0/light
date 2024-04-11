using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class curtainf : MonoBehaviour
{
    public int win = 0;
    public float startTime = -10f;
    public float transparent = 0;
    public int skipped = 0;
    AsyncOperation operation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(win == 1 && startTime == -10f)
        {
            startTime = Time.time;
            GetComponent<Image>().enabled = true;
        }

        if(win == 1)
        {
            transparent += 1f * Time.deltaTime;
            GetComponent<Image>().color = new Vector4(0f, 0f, 0f, transparent);
        }

        if(Time.time > startTime + 2f && Time.time < startTime + 3f && skipped == 0)
        {
            skipped = 1;
            StartCoroutine(loadScene());
        }

    }
    IEnumerator loadScene()
    {
        operation = SceneManager.LoadSceneAsync(7);
        yield return operation;
    }
}
