using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tLerp : MonoBehaviour
{
    public Transform playerTarget;
    public float moveTime;
    public void LateUpdate(){
        if (playerTarget!=null)//角色不为空
  {
     if (playerTarget.position!=transform.position)//相机和角色位置不相等的时候
        {
            transform.position = Vector3.Lerp(transform.position, playerTarget.position, moveTime*Time.deltaTime); 
        }
  }
    }
    //Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(playerTarget.position.y<9){
        LateUpdate();
       } 
    }
}
