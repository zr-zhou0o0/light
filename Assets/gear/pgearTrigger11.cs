using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgearTrigger11: MonoBehaviour
{
    public int pgearTrigger11Active = 0;
    public int relativeThingActive = 0;

    public int pgearActive = 0;

    public float wallStartTime = 0;
    public float wallMoveDeltaTime = 8;//这里改了游戏脚本面板里也要改，否则没用！！！血泪的教训！

    public GameObject gear;
    public GameObject wall1;

    // Start is called before the first frame update
    void Start()
    {
        gear = GameObject.Find("pgear11d");
        wall1 = GameObject.Find("pwall2d");

    }

    // Update is called once per frame
    void Update()
    {

        pgearActive = gear.GetComponent<pgear11>().pgear11Active;


        if (pgearTrigger11Active == 1)//&& (relativeThingActive == 0))
        {
            // Debug.Log("active gear and wall1 and wall2!");
            gear.transform.Rotate(new Vector3(0, 0, 1), 0.5f);//要一直转的话就不能限制relativethingactive！否则只转一瞬间，看不出来。

        }

        if ((pgearTrigger11Active == 1) && (relativeThingActive == 0))
        {
            wallStartTime = Time.time;
            GetComponent<AudioSource>().Play();
            relativeThingActive = 1;
            Debug.Log(Time.time);
            Debug.Log(wallMoveDeltaTime);
            Debug.Log(Time.time + wallMoveDeltaTime);
        }

        if ((Time.time > wallStartTime) && (Time.time < wallStartTime + wallMoveDeltaTime) && (relativeThingActive == 1))
        {
            wall1.transform.Translate(new Vector3(0, -3, 0) * 0.3f * Time.deltaTime);
        }


    }



    public void OnMouseDown()//要给物体加上collider2d和“是触发器”选项
    {
        Debug.Log("mouse down!");
        if (pgearActive == 1)//当齿轮亮着的时候
        {
            pgearTrigger11Active = 1;
            Debug.Log("pgeartrigger11active is 1");
        }
    }

}
