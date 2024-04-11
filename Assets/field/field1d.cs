using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class field1d : MonoBehaviour
{
    public GameObject spot;
    public GameObject spotTrigger;
   // public GameObject lamp;
    public int spotReady = 0;
    //public int lampReady = 0;
    public int startMove = 0;
    public float moveSpeed = 4f;//�����ٶ�������

    public int field1Active = 0;
    public GameObject fieldlMode;
    public GameObject fieldLight;//�����м��д���ű�+��1��

    // Start is called before the first frame update
    void Start()
    {
        spot = GameObject.Find("spot1");
        spotTrigger = GameObject.Find("spotTrigger1");
        fieldlMode = GameObject.Find("field1l");
        fieldLight = GameObject.Find("fieldlight");
       // lamp = GameObject.Find("light3d");
    }

    // Update is called once per frame
    void Update()
    {
        spotReady = spotTrigger.GetComponent<spotTrigger1>().startMove;
        //lampReady = lamp.GetComponent<light3controller>().light3Active;
        if(startMove == 1)
        {
            //������˵������һ����current���ڶ�����target
            spotTrigger.transform.position = Vector3.MoveTowards(spotTrigger.transform.position, this.transform.position, moveSpeed * Time.deltaTime);
        }

        
        if(spotTrigger.transform.position.x- this.transform.position.x < 0.1 && spotTrigger.transform.position.y - this.transform.position.y < 0.1)
        {
            startMove = 0;
            field1Active = 1;
        }
        

        if(field1Active == 1)
        {
            fieldlMode.GetComponent<SpriteRenderer>().enabled = true;


            //Ϊʲô�����������ã�����
            spotTrigger.GetComponent<spotTrigger1>().spotActive = 0;//����������ʧ��
            spot.GetComponent<ParticleSystem>().Stop();

            fieldLight.GetComponent<fieldlight1>().fieldlightActive = 1;//�ƺ�find�������š��»��ߵ�
        }


    }

    private void OnMouseDown()
    {
        Debug.Log("click");
        if(spotReady == 1)
        {
            startMove = 1;
        }

    }

}
