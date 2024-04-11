using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sky3Dead : MonoBehaviour
{
    public int dead = 0;
    public float startTime = -10f;
    public float transparent = 0;
    public int skipped = 0;
    AsyncOperation operation;
    public GameObject curtain;
    // Start is called before the first frame update
    void Start()
    {
        curtain = GameObject.Find("curtain");
    }

    // Update is called once per frame
    void Update()
    {
        if (dead == 1 && startTime == -10f)
        {
            startTime = Time.time;
            curtain.GetComponent<Image>().enabled = true;
        }

        if (dead == 1)
        {
            transparent += 1f * Time.deltaTime;
           curtain.GetComponent<Image>().color = new Vector4(0f, 0f, 0f, transparent);
        }

        if (Time.time > startTime + 2f && Time.time < startTime + 3f && skipped == 0)
        {
            skipped = 1;
            StartCoroutine(loadScene());
        }
    }
    IEnumerator loadScene()
    {
        operation = SceneManager.LoadSceneAsync(8);
        yield return operation;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        dead = 1;
    }
}
