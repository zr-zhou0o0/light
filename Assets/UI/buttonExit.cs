using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonExit : MonoBehaviour
{
    AsyncOperation operation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(operation.progress);//��������ȥ������ô�ڳ���ת��֮ǰ��һֱ����
    }


    public void clickButton()
    {
        Debug.Log("click");
        GetComponent<AudioSource>().Play();
        StartCoroutine(loadScene());

    }

    IEnumerator loadScene()
    {
        operation = SceneManager.LoadSceneAsync(0);
        yield return operation;
    }

}
