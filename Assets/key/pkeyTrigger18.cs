using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pkeyTrigger18 : MonoBehaviour
{
    public int pkeyTrigger18Active;
    public plight14controller anything;
    //public int lock31;
    // Start is called before the first frame update
    void Start()
    {
        pkeyTrigger18Active = 0;
        //lightcontroller = GameObject.Find("plight14controller");

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)//别忘了2d！！
    {

        pkeyTrigger18Active = 1;
        anything.keyorder14[4] = anything.keyorder14[3];
        anything.keyorder14[3] = anything.keyorder14[2];//将keyorder的数据向后推
        anything.keyorder14[2] = anything.keyorder14[1];
        anything.keyorder14[1] = anything.keyorder14[0];
        anything.keyorder14[0] = 18;    //把第一个keynumber的数据修改成琴键序号
        GetComponent<AudioSource>().Play();
        Debug.Log("pkeytrigger18is 1");
    }
}
