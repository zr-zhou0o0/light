using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wf3 : MonoBehaviour
{
    public int wf3atv = 0;
    public int wf3move = 0;
    public float transparent = 0;

    public float wallStartTime = 0;
    public float wallMoveDeltaTime = 5;
    public int relativeThingActive = 0;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (wf3atv == 1)
        {
            if (transparent <= 1)
            {
                transparent += 1f * Time.deltaTime;
            }
            GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, transparent);
        }

        if (wf3atv == 1 && wf3move == 1 && relativeThingActive == 0)
        {
            wallStartTime = Time.time;
            // GetComponent<AudioSource>().Play();
            relativeThingActive = 1;

        }

        if ((Time.time > wallStartTime) && (Time.time < wallStartTime + wallMoveDeltaTime) && (relativeThingActive == 1))
        {
            transform.Translate(new Vector3(0, 1, 0) * 0.5f * Time.deltaTime);
        }

    }
}
